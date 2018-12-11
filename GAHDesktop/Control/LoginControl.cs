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
    class LoginControl
    {
        LoginDAO TU = new LoginDAO();

        public bool cekLogin(string user, string pass)
        {
            bool cek = false;
            try
            {
                if (TU.CekLogin(user, pass).ToString() != "")
                    cek = true;
            }
            catch
            {
                cek = false;
            }
            return cek;
        }

        public MySqlDataAdapter GetRole(string user, string pass)
        {
            return TU.GetRole(user, pass);
        }
    }
}
