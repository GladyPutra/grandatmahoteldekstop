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
    class KelolaSeasonControl
    {
        KelolaSeasonDAO KSD = new KelolaSeasonDAO();

        //tampil data
        public MySqlDataAdapter TampilSeason()
        {
            return KSD.TampilSeason();
        }

        //input data
        public bool SimpanSeason(Season S)
        {
            return KSD.SimpanSeason(S);
        }

        //edit data
        public bool editSeason(Season S, int id)
        {
            return KSD.editSeason(S, id);
        }

        //Hapus data
        public bool hapusSeason(int id)
        {
            return KSD.hapusSeason(id);
        }

        /*public MySqlDataAdapter GetTgl(int id)
        {
            return KSD.GetTgl(id);
        }*/
    }
}
