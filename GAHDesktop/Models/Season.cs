using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAHDesktop.Models
{
    class Season
    {
        string Nama_season;

        public Season(string Nama_season)
        {
            this.Nama_season = Nama_season;

        }

        public string Nama_Season
        {
            get { return Nama_season; }
            set { Nama_season = value; }
        }

 
    }
}
