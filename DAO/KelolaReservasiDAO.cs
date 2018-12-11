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

namespace GAHDesktop.DAO
{
    class KelolaReservasiDAO
    {
        public MySqlDataAdapter TampilStatus()
        {
            DBConnect db = new DBConnect();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT checkin_checkout.ID_BOOKING, data_diri.NAMA,checkin_checkout.TGL_CHECKIN, checkin_checkout.TGL_CHECKOUT FROM checkin_checkout JOIN reservasi on checkin_checkout.ID_BOOKING = reservasi.ID_BOOKING JOIN data_diri on reservasi.ID_DATA_DIRI = data_diri.ID_DATA_DIRI";
                //cmd.Parameters.AddWithValue("@id", id);
                //cmd.ExecuteNonQuery();
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

        public MySqlDataAdapter cariReservasi(string id_booking_nama)
        {
            DBConnect db = new DBConnect();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT reservasi.ID_BOOKING, data_diri.NAMA, detil_reservasi.JENIS_TAMU FROM reservasi JOIN `detil_reservasi` ON reservasi.ID_BOOKING = detil_reservasi.ID_BOOKING JOIN data_diri ON data_diri.ID_DATA_DIRI = reservasi.ID_DATA_DIRI WHERE reservasi.ID_BOOKING = @cari OR data_diri.NAMA = @cari";
                cmd.Parameters.AddWithValue("@cari", id_booking_nama);
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

        public MySqlDataAdapter cariStatus(string id)
        {
            DBConnect db = new DBConnect();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT checkin_checkout.TGL_CHECKOUT FROM checkin_checkout WHERE ID_BOOKING = @id";
                cmd.Parameters.AddWithValue("@id", id);
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


        public void updateStatus(string id_booking, DateTime tgl)
        {

            DBConnect db = new DBConnect();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE `checkin_checkout` SET `TGL_CHECKIN`= @tgl WHERE ID_BOOKING = @id";
                cmd.Parameters.AddWithValue("@id", id_booking);
                cmd.Parameters.AddWithValue("@tgl", tgl);
                

                cmd.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public void updateStatusCheckOut(string id_booking, DateTime tgl)
        {
            DBConnect db = new DBConnect();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE `checkin_checkout` SET `TGL_CHECKOUT`= @tgl WHERE ID_BOOKING = @id";
                cmd.Parameters.AddWithValue("@id", id_booking);
                cmd.Parameters.AddWithValue("@tgl", tgl);
                statusKamar(id_booking);
                cmd.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }


        public MySqlDataAdapter CekKonfirmasi(string id)
        {
            DBConnect db = new DBConnect();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT `JENIS_STATUS` FROM `transaksi` WHERE  `NO_INVOICE` = @id";
                cmd.Parameters.AddWithValue("@id", id);
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

        public void statusKamar(string id_booking)
        {
            DBConnect db = new DBConnect();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                string status = "TERSEDIA";
                cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE `kamar` SET `STATUS_BOOKING`=@status WHERE kamar.ID_KAMAR = (SELECT reservasi.ID_KAMAR FROM reservasi WHERE reservasi.ID_BOOKING = @id)";
                cmd.Parameters.AddWithValue("@id", id_booking);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public bool konfirmasiPembayaran(KonfrimasiPembayaran CIN)
        {
            DBConnect db = new DBConnect();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO `checkin_checkout`(`DEPOSIT`, `CASH`, `ID_BOOKING`) VALUES (@deposit,@cash,@id); INSERT INTO `detil_transaksi_pembayaran`(`JENIS_PEMBAYARAN`, `NOMOR_KARTU_KREDIT`, `NO_INVOICE`) VALUES (@jenis,@kartu,@no)";
                cmd.Parameters.AddWithValue("@deposit", CIN.Deposit);
                cmd.Parameters.AddWithValue("@cash", CIN.Cash);
                cmd.Parameters.AddWithValue("@id", CIN.Id_Booking);
                cmd.Parameters.AddWithValue("@jenis", CIN.Jenis_pembayaran);
                cmd.Parameters.AddWithValue("@kartu", CIN.Nomor_kartu_kredit);
                cmd.Parameters.AddWithValue("@no", CIN.No_invoice);
                updateStatusPembayaran(CIN.No_invoice);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public void updateStatusPembayaran(string no_invoice)
        {
            DBConnect db = new DBConnect();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                string jenis = "LUNAS";
                cmd = conn.CreateCommand();
                cmd.CommandText = " UPDATE `transaksi` SET `JENIS_STATUS`= @jenis WHERE NO_INVOICE =@no";
                cmd.Parameters.AddWithValue("@no", no_invoice);
                cmd.Parameters.AddWithValue("@jenis", jenis);
                cmd.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public MySqlDataAdapter TampilDetilReservasi(string id)
        {
            DBConnect db = new DBConnect();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT data_diri.NAMA, detil_reservasi.JENIS_TAMU, detil_reservasi.JUMLAH_DEWASA, detil_reservasi.JUMLAH_ANAK, detil_reservasi.JUMLAH_TAMU, kota.NAMA_KOTA, detil_kamar.NAMA_KAMAR FROM `detil_reservasi` JOIN reservasi ON reservasi.ID_BOOKING = detil_reservasi.ID_BOOKING JOIN data_diri ON data_diri.ID_DATA_DIRI = reservasi.ID_DATA_DIRI JOIN kota ON kota.ID_KOTA = reservasi.ID_KOTA JOIN kamar ON kamar.ID_KAMAR = reservasi.ID_KAMAR JOIN detil_kamar ON detil_kamar.ID_DETIL_KAMAR = kamar.ID_DETIL_KAMAR WHERE reservasi.ID_BOOKING = @id";
                cmd.Parameters.AddWithValue("@id", id);
                //cmd.ExecuteNonQuery();
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

        public MySqlDataAdapter ComboItem(string id)
        {
            DBConnect db = new DBConnect();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT item.NAMA_ITEM FROM `reservasi` JOIN tarif ON reservasi.ID_TARIF = tarif.ID_TARIF JOIN detil_tarif ON detil_tarif.ID_TARIF = tarif.ID_TARIF JOIN item ON item.ID_ITEM = detil_tarif.ID_ITEM WHERE reservasi.ID_BOOKING = @id";
                cmd.Parameters.AddWithValue("@id", id);
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

        public void batalReservasi(string id_booking)
        {
            DBConnect db = new DBConnect();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                string status = "YA";
                cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE `detil_reservasi` SET `STATUS_BATAL`= @status WHERE detil_reservasi.ID_BOOKING = @id";
                cmd.Parameters.AddWithValue("@id", id_booking);
                cmd.Parameters.AddWithValue("@status", status);
                statusKamar(id_booking);
                cmd.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //return null;
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
