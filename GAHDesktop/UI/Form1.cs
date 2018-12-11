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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (LC.cekLogin(txtUser.Text, txtPass.Text) == true)
            {
                MySqlDataAdapter adapter = LC.GetRole(txtUser.Text, txtPass.Text);
                adapter.Fill(dt);
                string role = dt.Rows[0]["NAMA_ROLE"].ToString();
                if (role.ToLower() == "admin")
                {
                    label3.Text = role;
                    this.Hide();
                    FormAdmin A = new FormAdmin(role);
                    A.Show();
                }
                else
                {
                    MessageBox.Show("tidak memiliki role");
                }
            }

            else
            {
                MessageBox.Show("Username atau password salah");
            }
        }
    }
}
