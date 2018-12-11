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
    class LoginDAO
    {
        public bool CekLogin(string user, string pass)
        {
            DBConnect db = new DBConnect();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "Select USERNAME, PASSWORD from tbl_user join role on role.ID_ROLE = tbl_user.ID_ROLE where USERNAME = @user and PASSWORD = @pass";
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pass", pass);
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

        public MySqlDataAdapter GetRole(string user, string pass)
        {
            DBConnect db = new DBConnect();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "Select NAMA_ROLE from tbl_user join role on role.ID_ROLE = tbl_user.ID_ROLE where tbl_user.USERNAME = @user and tbl_user.PASSWORD = @pass";
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pass", pass);
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


        public MySqlDataAdapter CekUnik(string user)
        {
            DBConnect db = new DBConnect();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "Select USERNAME from tbl_user where USERNAME = @user";
                cmd.Parameters.AddWithValue("@user", user);
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

        public void editPassword(string pass, string nama)
        {
            DBConnect db = new DBConnect();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE tbl_user SET PASSWORD = @pass WHERE USERNAME = @nama";
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //return false;
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
