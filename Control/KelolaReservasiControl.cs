using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//tambah
using MySql.Data.MySqlClient;
using GAHDesktop.Models;
using GAHDesktop.DAO;
using System.Data;


namespace GAHDesktop.Control
{
    class KelolaReservasiControl
    {
        KelolaReservasiDAO KRD = new KelolaReservasiDAO();

        public MySqlDataAdapter TampilStatus()
        {
            return KRD.TampilStatus();
        }

        public MySqlDataAdapter cariReservasi(string cari)
        {
            return KRD.cariReservasi(cari);
        }

        public MySqlDataAdapter cariStatus(string cari)
        {
            return KRD.cariStatus(cari);
        }

        public void updateStatus(string id_booking, DateTime tgl)
        {
            KRD.updateStatus(id_booking, tgl);
        }

        public void updateStatusCheckOut(string id_booking, DateTime tgl)
        {
            KRD.updateStatusCheckOut(id_booking, tgl);
        }

        public bool KonfirmasiPembayaran(KonfrimasiPembayaran KP)
        {
            return KRD.konfirmasiPembayaran(KP);
        }

        public MySqlDataAdapter TampilReservasi(string id)
        {
            return KRD.TampilDetilReservasi(id);
        }

        public MySqlDataAdapter ComboItem(string id)
        {
            return KRD.ComboItem(id);
        }

        public void batalReservasi(string id)
        {
            KRD.batalReservasi(id);
        }

        public MySqlDataAdapter CekKonfirmasi(string id)
        {
            return KRD.CekKonfirmasi(id);
        }
    }
}
