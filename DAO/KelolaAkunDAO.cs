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
    class KelolaAkunDAO
    {
        public MySqlDataAdapter TampilAkun()
        {
            DBConnect db = new DBConnect();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT ID_USER,USERNAME, PASSWORD, NAMA_ROLE, NAMA_KOTA FROM tbl_user JOIN role on role.ID_ROLE = tbl_user.ID_ROLE JOIN kota on kota.ID_KOTA = tbl_user.ID_KOTA";
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

        public bool SimpanAkun(User US)
        {
            DBConnect db = new DBConnect();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO tbl_user(username, password, id_role, id_kota) VALUES(@user, @pass, @idrole, @idkota)";
                cmd.Parameters.AddWithValue("@user",US.Username);
                cmd.Parameters.AddWithValue("@pass", US.Pass);
                cmd.Parameters.AddWithValue("@idkota", US.Id_kota);
                cmd.Parameters.AddWithValue("@idrole", US.Id_role);
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

        public bool editAkun(User US, int id)
        {
            DBConnect db = new DBConnect();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE `tbl_user` SET `USERNAME`=@user,`PASSWORD`=@pass,`ID_ROLE`=@idrole,`ID_KOTA`=@idkota WHERE ID_USER = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@user", US.Username);
                cmd.Parameters.AddWithValue("@pass", US.Pass);
                cmd.Parameters.AddWithValue("@idrole", US.Id_role);
                cmd.Parameters.AddWithValue("@idkota", US.Id_kota);
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


        public MySqlDataAdapter Getidkota(string nama)
        {
            DBConnect db = new DBConnect();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT ID_KOTA FROM kota WHERE NAMA_KOTA = @nama";
                cmd.Parameters.AddWithValue("@nama", nama);
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

        public MySqlDataAdapter GetidRole(string nama)
        {
            DBConnect db = new DBConnect();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT ID_ROLE FROM role WHERE NAMA_ROLE = @nama";
                cmd.Parameters.AddWithValue("@nama", nama);
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

        public bool hapusAkun(int id)
        {
            DBConnect db = new DBConnect();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM tbl_user WHERE ID_USER = @id";
                cmd.Parameters.AddWithValue("@id", id);
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

        public MySqlDataAdapter cariAkun(string akun)
        {
            DBConnect db = new DBConnect();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT ID_USER,USERNAME, PASSWORD, ID_ROLE, ID_KOTA FROM tbl_user WHERE USERNAME = @nama";
                cmd.Parameters.AddWithValue("@nama", akun);
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
