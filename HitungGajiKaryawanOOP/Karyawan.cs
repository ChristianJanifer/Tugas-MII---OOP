using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitungGajiKaryawanOOP
{
    public class Karyawan : Pegawai
    {
		public string Id { get; set; }
		public string Nama { get; set; }
		public int LamaKerja { get; set; }
		public int GajiPokok { get; set; }
		public int TotalGaji { get; set; }

		private int bonus = 7000;

		private int Total;

        //Constructor yang membuat objek Karyawan dengan mengeset nilai kosong
        public Karyawan()
        {

        }

        //Constructor dengan beberapa atribut dari kelas Pegawai untuk membuat List Objek Karyawan
        public Karyawan(string idKaryawan, string namaKaryawan, int lamaKerja, int gajiPokok)
        {
            this.Id = idKaryawan;
            this.Nama = namaKaryawan;
            this.LamaKerja = lamaKerja;
            this.GajiPokok = gajiPokok;
            this.TotalGaji = HitungGaji(gajiPokok, lamaKerja);
        }

        //Override Fungsi HitungGaji dengan menurunkan sifat dari kelas Pegawai
        public override int HitungGaji(int gajipokok, int lamakerja)
		{
			Total = this.GajiPokok + (bonus * this.LamaKerja);
			return Total;
		}
    }
}
