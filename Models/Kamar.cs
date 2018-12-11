using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAHDesktop.Models
{
    class Kamar
    {
        string Id_kamar,Nama_kamar,Tempat_tidur, Status_smoking, Status_boking;
        int jumlah_kamar;

        public Kamar(string Id_kamar, string Nama_kamar, string Tempat_tidur, string Status_smoking, string Status_boking, int jumlah_kamar)
        {
            this.Id_kamar = Id_kamar;
            this.Nama_kamar = Nama_kamar;
            this.Tempat_tidur = Tempat_tidur;
            this.Status_smoking = Status_smoking;
            this.Status_boking = Status_boking;
            this.jumlah_kamar = jumlah_kamar;
        }

        public string Id_Kamar
        {
            get { return Id_kamar; }
            set { Id_kamar = value; }
        }

        public string Nama_Kamar
        {
            get { return Nama_kamar; }
            set { Nama_kamar = value; }
        }

        public string Tempat_Tidur
        {
            get { return Tempat_tidur; }
            set { Tempat_tidur = value; }
        }

        public string Status_Smoking
        {
            get { return Status_smoking; }
            set { Status_smoking = value; }
        }

        public string Status_Boking
        {
            get { return Status_boking; }
            set { Status_boking = value; }
        }

        public int Jumlah_Kamar
        {
            get { return jumlah_kamar; }
            set { jumlah_kamar = value; }
        }
    }
}
