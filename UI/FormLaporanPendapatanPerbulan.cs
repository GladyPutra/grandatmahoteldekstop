using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//tambahkan using
using GAHDesktop.Models;
using GAHDesktop.Control;
using MySql.Data.MySqlClient;

namespace GAHDesktop.UI
{
    public partial class FormLaporanPendapatanPerbulan : Form
    {
        public FormLaporanPendapatanPerbulan()
        {
            InitializeComponent();
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah anda yakin akan Keluar?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                Form1 A = new Form1();
                A.Show();
            }
        }

        private void kembaliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOwnerGM OW = new FormOwnerGM();
            OW.Show();
        }
    }
}
