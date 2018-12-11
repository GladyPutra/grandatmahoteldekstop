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
    public partial class FormKelolaSeason : Form
    {
        
        KelolaSeasonControl KSC = new KelolaSeasonControl();

        public FormKelolaSeason(string role)
        {
            InitializeComponent();
            enableButton(false);
            enableText(false);
            btnTambah.Enabled = true;
            cleardata();
            menuRole.Text = role;
            tempID.Visible = false;
        }

        private void cleardata()
        {
            txtSeason.Text = string.Empty;
            txtCari.Text = string.Empty;
        }

        private void enableButton(bool value)
        {
            btnSimpan.Enabled = value;
            btnEdit.Enabled = value;
            btnBatal.Enabled = value;
            btnHapus.Enabled = value;
            btnTambah.Enabled = value;
        }

        private void enableText(bool value)
        {
            txtSeason.Enabled = value;
        }


        private void FormKelolaSeason_Load(object sender, EventArgs e)
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
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = KSC.TampilSeason();
            adapter.Fill(dt);
            DG.DataSource = dt;

            DG.Columns[0].HeaderText = "ID";
            DG.Columns[1].HeaderText = "NAME";
    
            DG.Columns[0].Width = 70;
            DG.Columns[1].Width = 200;
    
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

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSeason.Text.Length > 0)
                {
                    string message = string.Empty;
                    string id = tempID.Text;
                    string nama_season = txtSeason.Text;
                    Season S = new Season(nama_season);

                    if (id.Length > 0 && btnSimpan.Text.ToLower() == "perbarui")
                    {
                        if (KSC.editSeason(S, int.Parse(id)))
                            message = "Data Berhasil Diperbarui";
                        cleardata();
                        enableButton(false);
                        enableText(false);
                        btnTambah.Enabled = true;
                        btnSimpan.Text = "Simpan";
                    }
                    else
                    {
                        if (KSC.SimpanSeason(S))
                        message = "Data berhasil disimpan";
                        
                        cleardata();
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
            tempID.Text = getColumn(dgView, 0);
            txtSeason.Text = getColumn(dgView, 1);
            string id;
            id = getColumn(dgView, 0);
            enableButton(true);
            btnSimpan.Enabled = false;
            enableText(false);
            //getTgl(id);

        }
        /*
        public void getTgl(string id)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = KSC.GetTgl(int.Parse(tempID.Text));
            adapter.Fill(dt);
            string role1 = dt.Rows[0]["TGL_MULAI"].ToString();
            string role2 = dt.Rows[0]["TGL_SELESAI"].ToString();

            txtTglMulai.Text = role1;
            txtTglSelesai.Text = role2;
        }
        */

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Yakin Hapus data?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    if (KSC.hapusSeason(int.Parse(tempID.Text)))
                    {
                        MessageBox.Show("Data berhasil dihapus", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cleardata();
                        enableButton(false);
                        enableText(false);
                        btnTambah.Enabled = true;
                    }
                    RefreshGridView();
                }
                catch
                {

                }
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            enableButton(true);
            enableText(true);
            btnTambah.Enabled = false;
            btnHapus.Enabled = false;
            btnSimpan.Text = "Perbarui";
            btnEdit.Enabled = false;
        }

        /*private void dgView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //setValueEdit();
            }
            catch
            {
                
            }
        }*/

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            string role = menuRole.Text;
            FormAdmin A = new FormAdmin(role);
            A.Show();
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

        private void btnTambah_Click(object sender, EventArgs e)
        {
            enableButton(false);
            enableText(true);
            btnSimpan.Enabled = true;
            btnBatal.Enabled = true;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            cleardata();
            enableButton(false);
            enableText(false);
            btnTambah.Enabled = true;
            btnSimpan.Text = "Simpan";
        }

        private void txtCari_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtCari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = KSC.CariSeason(txtCari.Text);
                adapter.Fill(dt);
                
                if (dt.Rows.Count > 0)
                {
                    string nama_season = dt.Rows[0]["NAMA_SEASON"].ToString();
                    txtSeason.Text = nama_season;
                    txtCari.Text = string.Empty;
                    enableButton(true);
                    enableText(true);
                    btnSimpan.Enabled = false;
                    txtSeason.Enabled = false;
                    
                }
                else if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Nama Season Tidak ditemukan", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtSeason_KeyPress(object sender, KeyPressEventArgs e)
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
