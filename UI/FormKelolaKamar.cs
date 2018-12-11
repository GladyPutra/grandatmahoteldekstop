using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//tambahkan using berikut
using GAHDesktop.Models;
using GAHDesktop.Control;
using MySql.Data.MySqlClient;

namespace GAHDesktop.UI
{
    public partial class FormKelolaKamar : Form
    {
        KelolaTarifKamarControl TKC = new KelolaTarifKamarControl();
        DataTable dt = new DataTable();
        ShowException SE = new ShowException();

        public FormKelolaKamar(string role)
        {
            InitializeComponent();
            RefreshGridView();
            //cmbnamaKamar();
            cmbnamaSeason();
            enableButton(false);
            enableText(false);
            btnTambah.Enabled = true;
            tempId.Visible = false;
            tempIdSeason.Visible = false;
            //tempIdDetilKamar.Visible = false;
            txtHargaKamar.MaxLength = 12;
            menuRole.Text = role;
        }

        private void clearData()
        {
            txtHargaKamar.Text = string.Empty;
            tempId.Text = string.Empty;
            tempIdSeason.Text = string.Empty;
            //tempIdDetilKamar.Text = string.Empty;
            cmbSeason.Text = string.Empty;
            //cmbNamaKamar.Text = string.Empty;
            dateTimePicker2.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
        }

        private void enableText(bool value)
        {
            txtHargaKamar.Enabled = value;
            tempId.Enabled = value;
            tempIdSeason.Enabled = value;
            //tempIdDetilKamar.Enabled = value;
            cmbSeason.Enabled = value;
            //cmbNamaKamar.Enabled = value;
            dateTimePicker2.Enabled = value;
            dateTimePicker1.Enabled = value;
        }

        private void enableButton(bool value)
        {
            btnSimpan.Enabled = value;
            btnEdit.Enabled = value;
            btnBatal.Enabled = value;
            btnHapus.Enabled = value;
            btnTambah.Enabled = value;
        }
        

        private void FormKelolaKamar_Load(object sender, EventArgs e)
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
            MySqlDataAdapter adapter = TKC.TampilTarifkamar();
            adapter.Fill(dt);
            DG.DataSource = dt;

            DG.Columns[0].HeaderText = "ID_Tarif";
            DG.Columns[1].HeaderText = "TglMulai";
            DG.Columns[2].HeaderText = "TglSelesai";
            DG.Columns[3].HeaderText = "Nama_season";
            DG.Columns[4].HeaderText = "Harga_Kamar";

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

        /*public void cmbnamaKamar()
        {
            MySqlConnection cn = new MySqlConnection("server=localhost;uid=root;pwd=;database=sigahfix");
                cn.Open();
                MySqlCommand cm = new MySqlCommand("select NAMA_KAMAR from detil_kamar", cn);
                MySqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    cmbNamaKamar.Items.Add(dr[0].ToString());
                }
                cn.Close();
        }*/

        public void cmbnamaSeason()
        {
            MySqlConnection cn = new MySqlConnection("server=192.168.19.140;uid=pp8561;pwd=8561;database=8561");
            cn.Open();
            MySqlCommand cm = new MySqlCommand("select NAMA_SEASON from season", cn);
            MySqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbSeason.Items.Add(dr[0].ToString());
            }
            cn.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHargaKamar.Text.Length > 0  && cmbSeason.Text.Length > 0 && dateTimePicker1.Text.Length > 0 && dateTimePicker2.Text.Length > 0)
                {
                    string message = string.Empty;
                    string id = tempId.Text;
                    //getId_kamar(cmbNamaKamar.Items.ToString());
                    getId_season(cmbSeason.Items.ToString());
                    string id_season = tempIdSeason.Text;
                    //string id_detilKamar = tempIdDetilKamar.Text;
                    DateTime tgl_mulai = DateTime.Parse(dateTimePicker1.Text);
                    DateTime tgl_selesai = DateTime.Parse(dateTimePicker2.Text);
                    string harga_kamar = txtHargaKamar.Text;

           
                    Tarif_Kamar T = new Tarif_Kamar(tgl_mulai, tgl_selesai, int.Parse(id_season), double.Parse(harga_kamar));
                    
                    if (id.Length > 0 && btnSimpan.Text.ToLower() == "perbarui")
                    {
                        if (TKC.EditKamar(T, int.Parse(id)))
                            message = "Edit data sukses";
                        clearData();
                        enableButton(false);
                        enableText(false);
                        btnTambah.Enabled = true;
                        btnSimpan.Text = "Simpan";
                    }
                    else
                    {
                        if (TKC.SimpanTarifKamar(T))
                            message = "Input data sukses";
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
                    MessageBox.Show("Tidak boleh kosong", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                //throw;
                Console.WriteLine(ex.Message);
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
            tempId.Text = getColumn(dgView, 0);
            string id;
            id = tempId.Text;
            get(id);
            RefreshGridView();

            enableButton(true);
            btnTambah.Enabled = false;
            btnSimpan.Enabled = false;
            enableText(false);
            txtCari.Text = string.Empty;
            //enableButton(true);
        }

        public void get(string id)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = TKC.GetData(int.Parse(tempId.Text));
            adapter.Fill(dt);
            string tgl_mulai = dt.Rows[0]["TGL_MULAI"].ToString();
            string tgl_selesai = dt.Rows[0]["TGL_SELESAI"].ToString();
            string id_season = dt.Rows[0]["ID_SEASON"].ToString();
            //string id_detil_kamar = dt.Rows[0]["ID_DETIL_KAMAR"].ToString();
            string harga_kamar = dt.Rows[0]["HARGA_KAMAR"].ToString();
            string nama_season = dt.Rows[0]["NAMA_SEASON"].ToString();
            //string nama_kamar = dt.Rows[0]["NAMA_KAMAR"].ToString();


            txtHargaKamar.Text = harga_kamar;
            tempIdSeason.Text = id_season;
            //tempIdDetilKamar.Text = id_detil_kamar;
            cmbSeason.Text = nama_season;
            //cmbNamaKamar.Text = nama_kamar;
            dateTimePicker2.Text = tgl_selesai;
            dateTimePicker1.Text = tgl_mulai;

            //cmbNamaKamar.Enabled = false;
            //dateTimePicker1.Visible = false;
            //dateTimePicker2.Visible = false;
        }


        /*public void getId_kamar(string nama)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = TKC.getIdKamar(cmbNamaKamar.Text);
            adapter.Fill(dt);
            
            string id_detil_kamar = dt.Rows[0]["ID_DETIL_KAMAR"].ToString();

            tempIdDetilKamar.Text = id_detil_kamar;
        }*/

        public void getId_season(string nama)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = TKC.GetIdSeason(cmbSeason.Text);
            adapter.Fill(dt);

            string id_season = dt.Rows[0]["ID_SEASON"].ToString();

            tempIdSeason.Text = id_season;
        }

        private void dgView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //getId_kamar(cmbNamaKamar.Items.ToString());
            getId_season(cmbSeason.Items.ToString());
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Yakin hapus?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (TKC.hapus(int.Parse(tempId.Text)))
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

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            string role = menuRole.Text;
            FormAdmin A = new FormAdmin(role);
            A.Show();
        }

        private void txtCari_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        public void setDatagridview2(DataGridView DG, string temp)
        {
            dt.Clear();
            MySqlDataAdapter adapter = TKC.CariKamar(temp);
            adapter.Fill(dt);
            DG.DataSource = dt;
            DG.Columns[0].HeaderText = "ID_TARIF";
            DG.Columns[1].HeaderText = "TGL_MULAI";
            DG.Columns[2].HeaderText = "TGL_SELESAI";
            DG.Columns[3].HeaderText = "HARGA_KAMAR";
            DG.Columns[4].HeaderText = "NAMA_SEASON";

            DG.Columns[0].Width = 100;
            DG.Columns[1].Width = 100;
            DG.Columns[2].Width = 100;
            DG.Columns[3].Width = 100;
            DG.Columns[4].Width = 100;

            settingHeaderGrid2(DG);
        }

        private void settingHeaderGrid2(DataGridView DG)
        {
            //=== Make Center Header in Data Grid View
            foreach (DataGridViewColumn col in DG.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        public void RefreshGridView2(string temp)
        {
            setDatagridview2(dgView, temp);
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

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clearData();
            enableButton(false);
            enableText(false);
            btnTambah.Enabled = true;
            btnSimpan.Text = "Simpan";
            txtCari.Enabled = true;
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

        private void txtHargaKamar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = TKC.CariKamar(txtCari.Text);
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    RefreshGridView2(txtCari.Text);
                }
                else if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Nama kamar Tidak ditemukan", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtCari_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            
            if (char.IsNumber(e.KeyChar))
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
