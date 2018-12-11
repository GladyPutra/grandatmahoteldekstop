using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//tambahan
using MySql.Data.MySqlClient;
using GAHDesktop.Models;
using GAHDesktop.DAO;
using System.Data;

namespace GAHDesktop.DAO
{
    class LaporanDAO
    {
        public MySqlDataAdapter TampilLaporanPendapatanPerJenisTamu()
        {
            DBConnect db = new DBConnect();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT Date_Format(tgl_transaksi,'%M') Tanggal_Transaksi, sum(JUMLAH_TARIF) JUMLAH_TARIF, jenis_tamu FROM `transaksi`JOIN reservasi on(transaksi.ID_BOOKING = reservasi.ID_BOOKING) JOIN detil_reservasi on(reservasi.ID_BOOKING = detil_reservasi.ID_BOOKING) where Date_Format(tgl_transaksi,'%Y') = 2018 GROUP BY tgl_transaksi,jenis_tamu ORDER BY tgl_transaksi";
                //cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                return adapter;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
