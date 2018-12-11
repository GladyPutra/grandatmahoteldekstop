using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAHDesktop.Models
{
    class Tarif_Kamar
    {
        double harga_kamar;
        int id_season;
        DateTime tgl_mulai, tgl_selesai;

        public Tarif_Kamar(DateTime tgl_mulai, DateTime tgl_selesai, int id_season, double harga_kamar)
        {
            this.tgl_mulai = tgl_mulai;
            this.tgl_selesai = tgl_selesai;
            this.harga_kamar = harga_kamar;
            this.id_season = id_season;
            //this.id_detil_kamar = id_detil_kamar;
        }

        public DateTime Tgl_mulai
        {
            get { return tgl_mulai; }
            set { tgl_mulai = value; }
        }

        public DateTime Tgl_selesai
        {
            get { return tgl_selesai; }
            set { tgl_selesai = value; }
        }

        public int Id_season
        {
            get { return id_season; }
            set { id_season = value; }
        }

        /*public int Id_detil_kamar
        {
            get { return id_detil_kamar; }
            set { id_detil_kamar = value; }
        }*/

        public double Harga_kamar
        {
            get { return harga_kamar; }
            set { harga_kamar = value; }
        }
    }
}
