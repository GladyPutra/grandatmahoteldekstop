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
namespace GAHDesktop.UI
{
    public partial class FormSalesMarketing : Form
    {
        public FormSalesMarketing(string role)
        {
            InitializeComponent();
            menuRole.Text = role;
        }

        private void btnKelolaReservasi_Click(object sender, EventArgs e)
        {
            this.Hide();
            string role = menuRole.Text;
            FormKonfirmasiPembayaran KN = new FormKonfirmasiPembayaran(role);
            KN.Show();
        }
    }
}
