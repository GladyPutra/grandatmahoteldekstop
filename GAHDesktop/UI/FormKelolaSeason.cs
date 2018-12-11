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
            menuRole.Text = role;
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
                string message = string.Empty;
                string id = tempID.Text;
                string nama_season = txtSeason.Text;
                Season S = new Season(nama_season);
                if (txtSeason.Text.Length > 0)
                {
                    if (id.Length > 0 && btnSimpan.Text.ToLower() == "update")
                    {
                        if (KSC.editSeason(S, int.Parse(id)))
                            message = "Update " + nama_season + " Success";
                    }
                    else
                    {
                        if (KSC.SimpanSeason(S))
                        message = "berhasil simpan " + nama_season + " ";
                    }
                    MessageBox.Show(message, "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            try
            {
                if (KSC.hapusSeason(int.Parse(tempID.Text)))
                {
                    MessageBox.Show("Deleted Success", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                RefreshGridView();
            }
            catch
            {
               
            }
        }

        private void setValueEdit()
        {
            tempID.Text = getColumn(dgView, 0);
            txtSeason.Text = getColumn(dgView, 1);
            btnSimpan.Text = "Update";
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            setValueEdit();
        }

        private void dgView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                setValueEdit();
            }
            catch
            {
                
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            string role = menuRole.Text;
            FormAdmin A = new FormAdmin(role);
            A.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
           Form1 S = new Form1();
            S.Show();
        }

       
    }
}
