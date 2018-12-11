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
    class KelolaTarifKamarControl
    {
        KelolaTarifKamarDAO TKD = new KelolaTarifKamarDAO();

        //tampil data
        public MySqlDataAdapter TampilTarifkamar()
        {
            return TKD.TampilTarifKamar();
        }

        //input data
        public bool SimpanTarifKamar(Tarif_Kamar T)
        {
            return TKD.SimpanKamar(T);
        }

        //edit data
        public bool EditKamar(Tarif_Kamar T, int id)
        {
            return TKD.editKamar(T, id);
        }
        

        //Hapus data
        public bool hapusSeason(int id)
        {
            return TKD.hapusTarif(id);
        }

        public MySqlDataAdapter GetData(int id)
        {
            return TKD.GetData(id);
        }

        public MySqlDataAdapter CariKamar(string kamar)
        {
            return TKD.cariKamar(kamar);
        }

        public MySqlDataAdapter getIdKamar(string nama)
        {
            return TKD.GetIdKamar(nama);
        }

        public MySqlDataAdapter GetIdSeason(string season)
        {
            return TKD.GetIdSeason(season);
        }

        public bool hapus(int id)
        {
            return TKD.hapusTarif(id);
        }

        public MySqlDataAdapter cariHargaKamar(string id)
        {
            return TKD.cariHargaKamar(id);
        }

        public MySqlDataAdapter cmbItem(string id)
        {
            return TKD.ComboItem(id);
        }

        public MySqlDataAdapter HargaItem(string id)
        {
            return TKD.selectHarga(id);
        }

        public MySqlDataAdapter NAMA_KAMAR(string id)
        {
            return TKD.ComboNama(id);
        }


    }
}
