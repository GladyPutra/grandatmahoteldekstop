using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAHDesktop.UI
{
    public partial class FormAdmin : Form
    {
        public FormAdmin(string role)
        {
            InitializeComponent();
            menuRole.Text = role;
        }

        private void btnKelolaSeason_Click(object sender, EventArgs e)
        {
            this.Hide();
            string role = menuRole.Text;
            FormKelolaSeason S = new FormKelolaSeason(role);
            S.Show();
        }

        private void btnKelolaKamar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnKelolaTarif_Click(object sender, EventArgs e)
        {
            this.Hide();
            string role = menuRole.Text;
           FormKelolaKamar K = new FormKelolaKamar(role);
           K.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah anda yakin akan Keluar?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                Form1 A = new Form1();
                A.Show();
            }
        }

        private void btnKelolaAkun_Click(object sender, EventArgs e)
        {
            this.Hide();
            string role = menuRole.Text;
           FormKelolaAkun AK = new FormKelolaAkun(role);
            AK.Show();
        }
    }
}
