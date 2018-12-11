using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//tambah untuk connect mysql
using MySql.Data.MySqlClient;

namespace GAHDesktop.DAO
{
    class DBConnect
    {
        private string server, database, uid, password;
        public string connectionString()
        {
            server = "192.168.19.140";
            database = "8561"; // Diganti nama database Anda
            uid = "pp8561";   // Username Anda, default username phpmyadmin adalah root
            password ="8561";   // Password username, default utk username root passwordnya kosong
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            return connectionString;
        }
    }
}
