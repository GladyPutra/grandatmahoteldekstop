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
    class kelolaAkunControl
    {
        KelolaAkunDAO KAD = new KelolaAkunDAO();
        //tampil data
        public MySqlDataAdapter TampilAkun()
        {
            return KAD.TampilAkun();
        }

        //input data
        public bool SimpanAkun(User US)
        {
            return KAD.SimpanAkun(US);
        }

        //edit data
        public bool EditAkun(User US, int id)
        {
            return KAD.editAkun(US, id);
        }

        //Hapus data
        public bool hapusAkun(int id)
        {
            return KAD.hapusAkun(id);
        }

        public MySqlDataAdapter GetIdKota(string nama)
        {
            return KAD.Getidkota(nama);
        }

        public MySqlDataAdapter GetIdRole(string nama)
        {
            return KAD.GetidRole(nama);
        }

        public MySqlDataAdapter CariAkun(string nama)
        {
            return KAD.cariAkun(nama);
        }
    }
}
