using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GAHDesktop.UI;

//tambah
using GAHDesktop.Control;
using GAHDesktop.Models;
using MySql.Data.MySqlClient;
namespace GAHDesktop
{
    public partial class Form1 : Form
    {
        //pembuatan object
        DataTable dt = new DataTable();
        LoginControl LC = new LoginControl();
        

        public Form1()
        {
            InitializeComponent();
            txtUser.MaxLength = 10;
            txtPass.MaxLength = 15;
        }


        private void btnLogin_Click_2(object sender, EventArgs e)
        {

            if (LC.cekLogin(txtUser.Text, txtPass.Text) == true)
            {
                if (txtPass.Text.Length != 0 && txtUser.Text.Length != 0)
                {
                    if (txtPass.Text.Length >= 4)
                    {
                        DataTable dt = new DataTable();
                        MySqlDataAdapter adapter = LC.GetRole(txtUser.Text, txtPass.Text);
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            string role = dt.Rows[0]["NAMA_ROLE"].ToString();
                            if (role.ToLower() == "admin")
                            {
                                this.Hide();
                                FormAdmin A = new FormAdmin(role);
                                A.Show();
                            }
                            else if(role.ToLower() == "front office")
                            {
                                this.Hide();
                                FormFrontOffice FO = new FormFrontOffice(role);
                                FO.Show();
                            }
                            else if (role.ToLower() == "sales & marketing")
                            {
                                this.Hide();
                                FormSalesMarketing SM = new FormSalesMarketing(role);
                                SM.Show();
                            }
                            else if (role.ToLower() == "general manager" || role.ToLower() == "owner")
                            {
                                this.Hide();
                                FormOwnerGM OW = new FormOwnerGM();
                                OW.Show();
                            }
                            else
                            {
                                MessageBox.Show("tidak memiliki role");
                            }

                        }
                        else if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Username atau Password salah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (txtPass.Text.Length < 4 && txtPass.Text.Length >= 1)
                    {
                        MessageBox.Show("Password minimal 4 digit", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Username atau Password tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void lupaPassword_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 F = new Form1();
            F.Enabled = false;
            FormLupaPassword LP = new FormLupaPassword(txtUser.Text);
            LP.Show();

        }
    }
}
