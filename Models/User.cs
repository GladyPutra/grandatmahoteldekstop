using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAHDesktop.Models
{
    class User
    {
        string user;
        string pass;
        int id_role;
        int id_kota;

        public User(string user, string pass, int id_role, int id_kota)
        {
            this.user = user;
            this.pass = pass;
            this.id_role = id_role;
            this.id_kota = id_kota;
        }

        public string Username
        {
            get { return user;}
            set { user = value; }
        }

        public string Pass
        {
            get { return pass;}
            set { pass = value; }
        }

        public int Id_role
        {
            get { return id_role; }
            set { id_role = value; }
        }

        public int Id_kota
        {
            get { return id_kota; }
            set { id_kota = value; }
        }

    }
}
