using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAHDesktop.Models
{
    class KonfrimasiPembayaran
    {

        //DateTime tglCheckIn;
        string id_booking, jenis_pembayaran, nomor_kartu, no_invoice, jenis_status;
        float deposit, cash, jumlah_tarif;
        DateTime tgl_transaksi;

        public KonfrimasiPembayaran(string jenis_pembayaran, string nomor_kartu_kredit, string no_invoice, float deposit, float cash, string id_booking)
        {
            //this.tglCheckIn = tglCheckIn;
            //this.tglCheckOut = tglCheckOut;
            this.jenis_pembayaran = jenis_pembayaran;
            this.nomor_kartu = nomor_kartu_kredit;
            this.no_invoice = no_invoice;
            this.deposit = deposit;
            this.cash = cash;
            this.id_booking = id_booking;
        }

        
        /*public DateTime Tgl_transaksi
        {
            get { return tgl_transaksi; }
            set { tgl_transaksi = value; }
        }

        /*public DateTime TglCheckOut
        {
            get { return tglCheckOut; }
            set { tglCheckOut = value; }
        }*/
        public string Jenis_pembayaran
        {
            get { return jenis_pembayaran; }
            set { jenis_pembayaran = value; }
        }

        public string Nomor_kartu_kredit
        {
            get { return nomor_kartu; }
            set { nomor_kartu = value; }
        }

        public string No_invoice
        {
            get { return no_invoice; }
            set { no_invoice = value; }
        }

        public float Deposit
        {
            get { return deposit; }
            set { deposit = value; }
        }

        public float Cash
        {
            get { return cash; }
            set { cash = value; }
        }

        public string Id_Booking
        {
            get { return id_booking; }
            set { id_booking = value; }
        }
    }
}
