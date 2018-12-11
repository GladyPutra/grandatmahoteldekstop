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
    public partial class FormKonfirmasiPembayaran : Form
    {
        KelolaTarifKamarControl TKC = new KelolaTarifKamarControl();
        KelolaReservasiControl KRC = new KelolaReservasiControl();
        public FormKonfirmasiPembayaran(string role)
        {
            InitializeComponent();
            menuRole.Text = role;
            txtCari.Visible = false;
            lblHargaItem.Text = "";
            lblHargaKamar.Text = "";
            lblTotalHarga.Text = "";
            //txtNamaKamar.Text = "";
            cmbNamaKamar.Enabled = false;
            txtNoKartu.Enabled = false;
            btnKonfirmasi.Enabled = false;
            txtNoKartu.Enabled = false;
        }

        private void txtId_Booking_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbnamaItem(txtId_Booking.Text);
                setHargakamar(txtId_Booking.Text);
                setHargaItem(txtId_Booking.Text);
                namaKamar(txtId_Booking.Text);
                float total_harga = float.Parse(lblHargaKamar.Text) + float.Parse(lblHargaItem.Text);
                lblTotalHarga.Text = total_harga.ToString();
                cmbNamaKamar.Enabled = true;
                txtNoKartu.Enabled = true;
                btnKonfirmasi.Enabled = true;
            }
        }

        public void setHargakamar(string id)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = TKC.cariHargaKamar(id);
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                //string namaKamar = dt.Rows[0]["NAMA_KAMAR"].ToString();
                //txtNamaKamar.Text = namaKamar;
                string harga = dt.Rows[0]["Harga_Kamar"].ToString();
                lblHargaKamar.Text = harga;
            }
        }

        public void namaKamar(string id)
        {
            cmbNamaKamar.Items.Clear();
            cmbNamaKamar.Text = string.Empty;
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = TKC.NAMA_KAMAR(id);
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                cmbNamaKamar.Text = "Lihat Kamar";
                int i;
                for (i = 0; i < dt.Rows.Count; i++)
                {
                    cmbNamaKamar.Items.Add(dt.Rows[i]["NAMA_KAMAR"].ToString());
                }
            }
            else
            {
                cmbNamaKamar.Text = "Tidak Ada Kamar";
            }
        }

        public void setHargaItem(string id)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = TKC.HargaItem(id);
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                lblHargaItem.Text = dt.Rows[0]["HARGA_ITEM"].ToString();
            }
        }
        public void cmbnamaItem(string id)
        {
            cmbItem.Items.Clear();
            cmbItem.Text = string.Empty;
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = TKC.cmbItem(id);
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                cmbItem.Text = "Lihat Item";
                int i;
                for (i = 0; i < dt.Rows.Count; i++)
                {
                    cmbItem.Items.Add(dt.Rows[i]["NAMA_ITEM"].ToString());
                }
            }
            else
            {
                cmbItem.Text = "Tidak Ada Item";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            if (cmbJenis.Text.ToLower() == "kredit")
            {
                if (txtNoKartu.Text != "")
                {
                    float deposit = 300000;
                    float cash = float.Parse(lblTotalHarga.Text) - deposit;
                    string id_booking_invoice = txtId_Booking.Text;
                    string jenis = cmbJenis.Text;
                    string no = txtNoKartu.Text;

                    KonfrimasiPembayaran KON = new KonfrimasiPembayaran(jenis, no, id_booking_invoice, deposit, cash, id_booking_invoice);

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = KRC.CekKonfirmasi(id_booking_invoice);
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        string JENIS = dt.Rows[0]["JENIS_STATUS"].ToString();
                        if (JENIS == "LUNAS")
                        {
                            MessageBox.Show("Sudah Lunas", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            DialogResult dr = MessageBox.Show("Apakah anda yakin untuk Konfirmasi Pembayaran?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dr == DialogResult.Yes)
                            {
                                KRC.KonfirmasiPembayaran(KON);
                                MessageBox.Show("Berhasil DiKonfirmasi", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No Rekening tidak boleh kosong", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                float deposit = 300000;
                float cash = float.Parse(lblTotalHarga.Text) - deposit;
                string id_booking_invoice = txtId_Booking.Text;
                string jenis = cmbJenis.Text;
                string no = "";

                KonfrimasiPembayaran KON = new KonfrimasiPembayaran(jenis, no, id_booking_invoice, deposit, cash, id_booking_invoice);

                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = KRC.CekKonfirmasi(id_booking_invoice);
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    string JENIS = dt.Rows[0]["JENIS_STATUS"].ToString();
                    if (JENIS == "LUNAS")
                    {
                        MessageBox.Show("Sudah Lunas", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("Apakah anda yakin untuk Konfirmasi Pembayaran?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            KRC.KonfirmasiPembayaran(KON);
                            MessageBox.Show("Berhasil DiKonfirmasi", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            
            
        }

        private void cmbJenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbJenis.Text == "Transfer")
            {
                txtNoKartu.Enabled = false;
            }
            else
            {
                txtNoKartu.Enabled = true;
            }
        }

        private void btnBatalReservasi_Click(object sender, EventArgs e)
        {
            if (txtId_Booking.Text != "" && lblTotalHarga.Text != "labe7")
            {
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = KRC.CekKonfirmasi(txtId_Booking.Text);
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    string JENIS = dt.Rows[0]["JENIS_STATUS"].ToString();
                    if (JENIS == "LUNAS")
                    {
                        MessageBox.Show("Tidak Bisa Di Batalkan, telah Lunas Membayar", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("Apakah anda yakin untuk batal reservasi?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            KRC.batalReservasi(txtId_Booking.Text);
                            MessageBox.Show("Reservasi Berhasil Dibatalkan", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Data Tidak ada", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
           
                       
        }

        private void txtNoKartu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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
    }
}
