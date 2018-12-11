using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAHDesktop.Models
{
    class LoginModels
    {
         string user, pass;
        public LoginModels(string user, string pass)
        {
            this.user = user;
            this.pass = pass;
        }

        public string Userr
        {
            get { return user; }
            set { user = value; }
        }

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
    }
}
