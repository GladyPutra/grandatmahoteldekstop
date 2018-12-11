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
    class laporanControl
    {
        LaporanDAO LD = new LaporanDAO();
        public MySqlDataAdapter TampilPendapatanperJenisTamuPerBulan()
        {
            return LD.TampilLaporanPendapatanPerJenisTamu();
        }
    }
}
