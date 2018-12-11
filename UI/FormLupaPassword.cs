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
    public partial class FormLupaPassword : Form
    {
        LoginControl LC = new LoginControl();
        public FormLupaPassword(string nama)
        {
            InitializeComponent();
            txtNamaPengguna.Text = nama;
            txtRandomPass.Enabled = false;
            txtRandomPass.Visible = false;
        }

        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Anda yakin membuat password baru?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                LC.GantiPassword(txtRandomPass.Text, txtNamaPengguna.Text);
                MessageBox.Show("Password berhasil diganti", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPassBaru_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = LC.Cekunik(txtNamaPengguna.Text);
            adapter.Fill(dt);
            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("Nama Pengguna tidak ada!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRandomPass.Visible = false;
            }
            else
            {
                if (dt.Rows[0]["USERNAME"].ToString() == txtNamaPengguna.Text)
                {
                    char[] letters = "qwertyuiopasdfghjklzxcvbnm123456780".ToCharArray();
                    Random r = new Random();
                    string randomString = "";
                    for (int i = 0; i < 5; i++)
                    {
                        randomString += letters[r.Next(0, 35)].ToString();
                    }
                    txtRandomPass.Text = randomString;
                    txtRandomPass.Visible = true;
                }
                else
                    MessageBox.Show("Nama Pengguna tidak ada!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
    }
}
