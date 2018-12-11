using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//tambah
using GAHDesktop.Control;
using GAHDesktop.Models;
using MySql.Data.MySqlClient;

namespace GAHDesktop.UI
{
    public partial class FormKelolaAkun : Form
    {
        kelolaAkunControl KA = new kelolaAkunControl();
        DataTable dt = new DataTable();
        public FormKelolaAkun(string role)
        {
            InitializeComponent();
            tempID.Visible = false;
            tempIDKota.Visible = false;
            tempIDRole.Visible = false;
            CMBKota();
            CMBRole();
            enableButton(false);
            enableText(false);
            btnTambah.Enabled = true;
            RefreshGridView();

            menuRole.Text = role;
        }

        public void enableButton(bool value)
        {
            btnSimpan.Enabled = value;
            btnEdit.Enabled = value;
            btnBatal.Enabled = value;
            btnHapus.Enabled = value;
            btnTambah.Enabled = value;
        }

        public void enableText(bool value)
        {
            txtUser.Enabled = value;
            txtPass.Enabled = value;
            txtCari.Enabled = value;
            cmbKota.Enabled = value;
            cmbRole.Enabled = value;
        }

        public void clearData()
        {
            txtUser.Text = string.Empty;
            txtPass.Text = string.Empty;
            txtCari.Text = string.Empty;
            cmbRole.Text = string.Empty;
            cmbKota.Text = string.Empty;
           // txtKonfirmasi.Text = string.Empty;
        }

        public void CMBKota()
        {
            MySqlConnection cn = new MySqlConnection("server=192.168.19.140;uid=pp8561;pwd=8561;database=8561");
            cn.Open();
            MySqlCommand cm = new MySqlCommand("select NAMA_KOTA from kota", cn);
            MySqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbKota.Items.Add(dr[0].ToString());
            }
            cn.Close();
        }

        public void CMBRole()
        {
            MySqlConnection cn = new MySqlConnection("server=192.168.19.140;uid=pp8561;pwd=8561;database=8561");
            cn.Open();
            MySqlCommand cm = new MySqlCommand("select NAMA_ROLE from role", cn);
            MySqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbRole.Items.Add(dr[0].ToString());
            }
            cn.Close();
        }

        public void getId_kota(string kota)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = KA.GetIdKota(cmbKota.Text);
            adapter.Fill(dt);

            string id_kota = dt.Rows[0]["ID_KOTA"].ToString();

            tempIDKota.Text = id_kota;
        }

        public void getId_role(string role)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = KA.GetIdRole(cmbRole.Text);
            adapter.Fill(dt);

            string id_role = dt.Rows[0]["ID_ROLE"].ToString();

            tempIDRole.Text = id_role;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {

                if (txtUser.Text.Length > 0)
                {
                    string message = string.Empty;

                    string id = tempID.Text;
                    string user = txtUser.Text;
                    string pass = txtPass.Text;
                    getId_kota(cmbKota.Items.ToString());
                    getId_role(cmbRole.Items.ToString());
                    int id_role = int.Parse(tempIDRole.Text);
                    int id_kota = int.Parse(tempIDKota.Text);
                    User US = new User(user, pass, id_role, id_kota);

                    if (btnSimpan.Text.ToLower() == "perbarui")
                    {
                        if (KA.EditAkun(US, int.Parse(id)))
                        message = "Data Berhasil Diperbarui";
                        clearData();
                        enableButton(false);
                        enableText(false);
                        btnTambah.Enabled = true;
                        btnSimpan.Text = "Simpan";
                    }
                    else
                    {
                        if (KA.SimpanAkun(US))
                            message = "Data berhasil disimpan";

                        clearData();
                        enableButton(false);
                        enableText(false);
                        btnTambah.Enabled = true;
                    }
                    MessageBox.Show(message, "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGridView();
                }
                else
                {
                    MessageBox.Show("Tidak boleh kosong", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        private void FormKelolaAkun_Load(object sender, EventArgs e)
        {
            try
            {
                setDatagridview(dgView);
            }
            catch (Exception ex)
            {
                //throw;
                Console.WriteLine(ex.Message);
            }
        }

        public void setDatagridview(DataGridView DG)
        {
            dt.Clear();
            MySqlDataAdapter adapter = KA.TampilAkun();
            adapter.Fill(dt);
            DG.DataSource = dt;

            DG.Columns[0].HeaderText = "ID_Akun";
            DG.Columns[1].HeaderText = "Pengguna";
            DG.Columns[2].HeaderText = "Password";
            DG.Columns[3].HeaderText = "ID_ROLE";
            DG.Columns[4].HeaderText = "ID_KOTA";
            

            DG.Columns[0].Width = 100;
            DG.Columns[1].Width = 100;
            DG.Columns[2].Width = 100;
            DG.Columns[3].Width = 100;
            DG.Columns[4].Width = 100;

            settingHeaderGrid(DG);
        }

        private void settingHeaderGrid(DataGridView DG)
        {
            //=== Make Center Header in Data Grid View
            foreach (DataGridViewColumn col in DG.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        public void RefreshGridView()
        {
            setDatagridview(dgView);
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            enableButton(true);
            enableText(true);

            btnHapus.Enabled = false;
            btnEdit.Enabled = false;
            txtCari.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            enableText(true);
            btnSimpan.Enabled = true;
            btnHapus.Enabled = false;
            btnSimpan.Text = "Perbarui";
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Yakin hapus?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (KA.hapusAkun(int.Parse(tempID.Text)))
                {
                    clearData();
                    enableButton(false);
                    enableText(false);
                    btnTambah.Enabled = true;
                    MessageBox.Show("Data Berhasil di hapus", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                RefreshGridView();
            }   
        }

        private string getColumn(DataGridView dg, int i)
        {
            string kolom = null;
            try
            {
                kolom = dg[dg.Columns[i].Index, dg.CurrentRow.Index].Value.ToString();
            }
            catch
            {

            }
            return kolom;
        }

        private void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tempID.Text = getColumn(dgView, 0);
            txtUser.Text = getColumn(dgView, 1);
            txtPass.Text = getColumn(dgView, 2);
            cmbRole.Text = getColumn(dgView, 3);
            cmbKota.Text = getColumn(dgView, 4);

            RefreshGridView();

            enableButton(true);
            btnTambah.Enabled = false;
            btnSimpan.Enabled = false;
            enableText(false);
            txtCari.Text = string.Empty;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah anda yakin akan Keluar?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                Form1 A = new Form1();
                A.Show();
            }
        }

        private void Kembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            string role = menuRole.Text;
            FormAdmin A = new FormAdmin(role);
            A.Show();
        }


    }
}
