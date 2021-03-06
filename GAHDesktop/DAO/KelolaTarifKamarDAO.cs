﻿using System;
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
    class KelolaTarifKamarDAO
    {
        public MySqlDataAdapter TampilTarifKamar()
        {
            DBConnect db = new DBConnect();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT tarif_season.ID_TARIF_SEASON, detil_kamar.NAMA_KAMAR, tarif_season.HARGA_KAMAR FROM detil_kamar JOIN tarif_season ON detil_kamar.ID_DETIL_KAMAR = tarif_season.ID_DETIL_KAMAR";
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

        public bool SimpanKamar(Tarif_Kamar T)
        {
            DBConnect db = new DBConnect();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO `tarif_season`(`TGL_MULAI`, `TGL_SELESAI`, `ID_SEASON`, `ID_DETIL_KAMAR`, `HARGA_KAMAR`) VALUES ( @tgl_mulai, @tgl_selesai, @id_season,@id_detil_kamar, @harga_kamar)";
                
                cmd.Parameters.AddWithValue("@tgl_mulai", T.Tgl_mulai);
                cmd.Parameters.AddWithValue("@tgl_selesai", T.Tgl_selesai);
                cmd.Parameters.AddWithValue("@id_season", T.Id_season);
                cmd.Parameters.AddWithValue("@id_detil_kamar", T.Id_detil_kamar);
                cmd.Parameters.AddWithValue("@harga_kamar", T.Harga_kamar);
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
        
        public bool editKamar(Tarif_Kamar T, int id)
        {
            DBConnect db = new DBConnect();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE `tarif_season` SET `TGL_MULAI` = @tgl_mulai, `TGL_SELESAI` = @tgl_selesai, `ID_SEASON` = @id_season, `ID_DETIL_KAMAR` = @id_detil_kamar, `HARGA_KAMAR` = @harga_kamar WHERE ID_TARIF_SEASON = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@tgl_mulai", T.Tgl_mulai);
                cmd.Parameters.AddWithValue("@tgl_selesai", T.Tgl_selesai);
                cmd.Parameters.AddWithValue("@id_season", T.Id_season);
                cmd.Parameters.AddWithValue("@id_detil_kamar", T.Id_detil_kamar);
                cmd.Parameters.AddWithValue("@harga_kamar", T.Harga_kamar);
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

        public bool hapusTarif(int id)
        {
            DBConnect db = new DBConnect();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM tarif_season WHERE ID_TARIF_SEASON = @id";
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

        public MySqlDataAdapter GetData(int id)
        {
            DBConnect db = new DBConnect();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT `ID_TARIF_SEASON`, `TGL_MULAI`, `TGL_SELESAI`, tarif_season.`ID_SEASON`, tarif_season.ID_DETIL_KAMAR, `HARGA_KAMAR`, NAMA_SEASON, NAMA_KAMAR FROM `tarif_season` JOIN season ON season.ID_SEASON = tarif_season.ID_SEASON JOIN detil_kamar ON detil_kamar.ID_DETIL_KAMAR = tarif_season.ID_DETIL_KAMAR WHERE ID_TARIF_SEASON = @id";
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

        public MySqlDataAdapter GetIdKamar(string nama)
        {
            DBConnect db = new DBConnect();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT ID_DETIL_KAMAR FROM detil_kamar WHERE NAMA_KAMAR = @nama";
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

        public MySqlDataAdapter GetIdSeason(string nama)
        {
            DBConnect db = new DBConnect();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT ID_SEASON FROM season WHERE NAMA_SEASON = @nama";
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

        public MySqlDataAdapter cariKamar(string id)
        {
            DBConnect db = new DBConnect();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT NAMA_KAMAR, `ID_TARIF_SEASON`, `TGL_MULAI`, `TGL_SELESAI`,`HARGA_KAMAR`, NAMA_SEASON FROM `tarif_season` JOIN season ON season.ID_SEASON = tarif_season.ID_SEASON JOIN detil_kamar ON detil_kamar.ID_DETIL_KAMAR = tarif_season.ID_DETIL_KAMAR WHERE NAMA_KAMAR = @id";
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
    }
}
