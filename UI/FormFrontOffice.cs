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
    public partial class FormFrontOffice : Form
    {

        KelolaReservasiControl KRC = new KelolaReservasiControl();

        public FormFrontOffice(string role)
        {
            InitializeComponent();
            menuRole.Text = role;
            RefreshGridView();
            btnCheckOut.Enabled = false;
            btnChekIn.Enabled = false;
            tempTgl.Visible = false;
            btnKonfrimasi.Visible = false;
            btnKonfrimasi.Enabled = false;
            visibleText(false);
            dgView2.Visible = false;
            txtCari.Visible = true;
        }

        public void enableText(bool value)
        {
            txtNoKartu.Enabled = value;
            txtNamaKamar.Enabled = value;
            txtNama.Enabled = value;
            txtKota.Enabled = value;
            txtJumlahTamu.Enabled = value;
            txtJumlahDesawa.Enabled = value;
            txtJumlahAnak.Enabled = value;
            txtJenisTamu.Enabled = value;
            txtId.Enabled = value;
            cmbItem.Enabled = value;
        }

        public void visibleText(bool value)
        {
            txtNoKartu.Visible = value;
            txtNamaKamar.Visible = value;
            txtNama.Visible = value;
            txtKota.Visible = value;
            txtJumlahTamu.Visible = value;
            txtJumlahDesawa.Visible = value;
            txtJumlahAnak.Visible = value;
            txtJenisTamu.Visible = value;
            txtId.Visible = value;
            txtCari.Visible = value;
            cmbItem.Visible = value;
            cmbJenis.Visible = value;

            label1.Visible = value;
            label2.Visible = value;
            label3.Visible = value;
            label4.Visible = value;
            label5.Visible = value;
            label6.Visible = value;
            label7.Visible = value;
            label8.Visible = value;
            label9.Visible = value;
            label10.Visible = value;
            label14.Visible = value;
            label15.Visible = value;
        }

        public void cleartText()
        {
            txtNoKartu.Text = string.Empty;
            txtNamaKamar.Text = string.Empty;
            txtNama.Text = string.Empty;
            txtKota.Text = string.Empty;
            txtJumlahTamu.Text = string.Empty;
            txtJumlahDesawa.Text = string.Empty;
            txtJumlahAnak.Text = string.Empty;
            txtJenisTamu.Text = string.Empty;
            txtId.Text = string.Empty;
            txtCari.Text = string.Empty;
        }

        public void setDatagridview(DataGridView DG)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = KRC.TampilStatus();
            adapter.Fill(dt);
            DG.DataSource = dt;

            DG.Columns[0].HeaderText = "ID_BOOKING";
            DG.Columns[1].HeaderText = "Nama";
            DG.Columns[2].HeaderText = "TGL_CHECKIN";
            DG.Columns[3].HeaderText = "TGL_CHECKOUT";

            DG.Columns[0].Width = 100;
            DG.Columns[1].Width = 100;
            DG.Columns[2].Width = 100;
            DG.Columns[3].Width = 100;

            settingHeaderGrid(DG);
        }

        public void setDatagridview2(DataGridView DG, string cari)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = KRC.cariReservasi(cari);
            adapter.Fill(dt);
            DG.DataSource = dt;

            DG.Columns[0].HeaderText = "ID_BOOKING";
            DG.Columns[1].HeaderText = "Nama";
            DG.Columns[2].HeaderText = "Jenis Tamu";

            DG.Columns[0].Width = 100;
            DG.Columns[1].Width = 100;
            DG.Columns[2].Width = 100;

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

        private void txtCari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = KRC.CekKonfirmasi(txtCari.Text);
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    string JENIS = dt.Rows[0]["JENIS_STATUS"].ToString();
                    if (JENIS == "LUNAS")
                    {
                        btnKonfrimasi.Visible = false;
                        btnKonfrimasi.Enabled = false;
                        MessageBox.Show("Sudah Lunas", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        visibleText(false);
                    }
                    else
                    {
                        btnKonfrimasi.Visible = true;
                        btnKonfrimasi.Enabled = true;
                        setDatagridview2(dgView2, txtCari.Text);
                        setDatagridview(dgView);
                        dgView2.Visible = true;
                        visibleText(false);
                    }
                    
                }
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

        private void dgView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgView2.Visible = false;
            txtId.Text = getColumn(dgView2, 0);
            cmbnamaItem(txtId.Text);
            btnKonfrimasi.Enabled = true;
            btnKonfrimasi.Visible = true;
            visibleText(true);
            

            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = KRC.TampilReservasi(txtId.Text);
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                txtNama.Text = dt.Rows[0]["NAMA"].ToString();
                txtJenisTamu.Text =  dt.Rows[0]["JENIS_TAMU"].ToString();
                txtJumlahDesawa.Text = dt.Rows[0]["JUMLAH_DEWASA"].ToString();
                txtJumlahAnak.Text = dt.Rows[0]["JUMLAH_ANAK"].ToString();
                txtJumlahTamu.Text = dt.Rows[0]["JUMLAH_TAMU"].ToString();
                txtKota.Text = dt.Rows[0]["NAMA_KOTA"].ToString();
                txtNamaKamar.Text = dt.Rows[0]["NAMA_KAMAR"].ToString();
            }
        }

        private void btnChekIn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("CheckIn Tamu?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DateTime tgl = tempTgl.Value.Date;
                KRC.updateStatus(txtId.Text, tgl);
                RefreshGridView();
                visibleText(false);
                btnChekIn.Enabled = false;
                btnCheckOut.Enabled = false;
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("CheckOut Tamu?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DateTime tgl = tempTgl.Value.Date;
                KRC.updateStatusCheckOut(txtId.Text, tgl);
                btnCheckOut.Enabled = false;
                RefreshGridView();
                visibleText(false);
                btnChekIn.Enabled = false;
                btnCheckOut.Enabled = false;
                btnKonfrimasi.Visible = false;
                btnKonfrimasi.Enabled = false;
                enableText(false);
            }
        }

        private void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgView2.Visible = false;
            txtId.Text = getColumn(dgView, 0);
            cmbnamaItem(txtId.Text);
            visibleText(true);
            btnCheckOut.Enabled = false;
            btnChekIn.Enabled = false;
            btnKonfrimasi.Visible = false;
            btnKonfrimasi.Enabled = false;
            enableText(false);
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = KRC.TampilReservasi(txtId.Text);
            adapter.Fill(dt);
            
            if (dt.Rows.Count > 0)
            {
                txtNama.Text = dt.Rows[0]["NAMA"].ToString();
                txtJenisTamu.Text = dt.Rows[0]["JENIS_TAMU"].ToString();
                txtJumlahDesawa.Text = dt.Rows[0]["JUMLAH_DEWASA"].ToString();
                txtJumlahAnak.Text = dt.Rows[0]["JUMLAH_ANAK"].ToString();
                txtJumlahTamu.Text = dt.Rows[0]["JUMLAH_TAMU"].ToString();
                txtKota.Text = dt.Rows[0]["NAMA_KOTA"].ToString();
                txtNamaKamar.Text = dt.Rows[0]["NAMA_KAMAR"].ToString();
                
            }

            if (getColumn(dgView, 2) == "" && getColumn(dgView, 3) == "")
            {
                btnChekIn.Enabled = true;
                
            }
            else if (getColumn(dgView, 2) != "" && getColumn(dgView, 3) == "")
            {
                btnCheckOut.Enabled = true;
            }
            else if (getColumn(dgView, 3) == "")
            {
                btnCheckOut.Enabled = true;
            }
        }

        private void btnKonfrimasi_Click(object sender, EventArgs e)
        {
            if (cmbJenis.Text.ToLower() == "kredit")
            {
                if (txtNoKartu.Text != "")
                {
                    float deposit = 300000;
                    float cash = 123;
                    string id_booking_invoice = txtId.Text;
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
                else if (cmbJenis.Text.ToLower() == "pilih")
                {
                    MessageBox.Show("Pili Terlebih Dahulu", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No Rekening tidak boleh kosong", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                float deposit = 300000;
                float cash = 123;
                string id_booking_invoice = txtId.Text;
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
                            visibleText(false);
                        }
                        else
                        {
                            visibleText(false);
                        }
                    }
                }
            }
            /*
            float deposit = 300000;
            float cash = 123;
            string id_booking_invoice = txtId.Text;
            string jenis = cmbJenis.Text;
            string no = txtNoKartu.Text;

            KonfrimasiPembayaran KON = new KonfrimasiPembayaran(jenis, no, id_booking_invoice, deposit, cash, id_booking_invoice);

            DialogResult dr = MessageBox.Show("Apakah anda yakin untuk Konfirmasi Pembayaran?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                KRC.KonfirmasiPembayaran(KON);
                RefreshGridView();
                enableText(false);
                btnKonfrimasi.Enabled = false;
            }*/
        }

        public void cmbnamaItem(string id)
        {
            cmbItem.Items.Clear();
            cmbItem.Text = string.Empty;
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = KRC.ComboItem(id);
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
