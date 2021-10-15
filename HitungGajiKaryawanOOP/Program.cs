using System;
using System.Collections.Generic;

namespace HitungGajiKaryawanOOP
{
   public class Program : Karyawan
    {
        public static void Main()
        {
			int keluar = 0;

			// Pembuatan List dari kelas Karyawan dengan menginialisasi objek KaryawanList
			List<Karyawan> karyawanList = new List<Karyawan>();

			do
			{
				int pilihmenu;
				Console.WriteLine();
				Menu();
                try
                {
					pilihmenu = int.Parse(Console.ReadLine());
					switch (pilihmenu)
					{
						case 1:
							Console.Clear();
							InputDataGajiKaryawan(karyawanList);
							break;
						case 2:
							Console.Clear();
							TampilDataGajiKaryawan(karyawanList);
							break;
						case 3:
							Console.Clear();
							Console.WriteLine();
							Console.Write("Cari ID Karyawan : ");
							string id = Console.ReadLine();
							TampilDataGajiKaryawan(karyawanList, id);
							break;
						case 4:
							Console.Clear();
							UbahDataGajiKaryawan(karyawanList);
							break;
						case 5:
							Console.Clear();
							HapusDataGajiKaryawan(karyawanList);
							break;
						case 6:
							Console.WriteLine();
							keluar = 6;
							Console.WriteLine("Program Hitung Gaji Karyawan Selesai");
							break;
						default:
							break;
					}
				}
                catch (FormatException E)
                {
					Console.WriteLine();
					Console.WriteLine("Inputan Salah, ULANGI. Tekan ENTER");
					Console.ReadLine();
					Console.Clear();
				}
			}
			while (keluar != 6);
		}

		public static void InputDataGajiKaryawan(List<Karyawan> karyawanList)
		{
			//inisialisasi objek dari class pegawai
			//Pegawai pgw = new Pegawai();

			Console.WriteLine();
			Console.Write("Masukkan Banyak Data Karyawan Yang Diinput : ");
			int banyakData = int.Parse(Console.ReadLine());

			Console.WriteLine();
			Console.WriteLine("--------Masukkan Data Karyawan--------");
			Console.WriteLine("--------------------------------------");
			Console.WriteLine();

			for (int j = 0; j < banyakData; j++)
            {
				Console.Write("ID Karyawan : ");
				string id = Console.ReadLine();

				Console.Write("Nama Karyawan : ");
				string nama = Console.ReadLine();

				Console.Write("Lama Kerja (Bulan) : ");
				int lamaKerja = int.Parse(Console.ReadLine());

				Console.Write("Gaji Pokok : ");
				int gajiPokok = int.Parse(Console.ReadLine());

				//karyawanList.Add(new Karyawan(pgw.id, pgw.nama, pgw.lamakerja, pgw.gajipokok));
				karyawanList.Add(new Karyawan(id, nama, lamaKerja, gajiPokok));
				Console.WriteLine();
			}
			
			Console.WriteLine();
			Console.WriteLine("Tekan ENTER untuk kembali ke Menu");
			Console.ReadLine();
			Console.Clear();
		}

		public static void TampilDataGajiKaryawan(List<Karyawan> karyawanList)
		{
			Console.WriteLine();
			Console.WriteLine("---------Lihat Data Gaji Karyawan---------");
			Console.WriteLine("------------------------------------------");
			Console.WriteLine();

			foreach (var karyawan in karyawanList)
			{
				Console.WriteLine($"ID Karyawan : {karyawan.Id}");
				Console.WriteLine($"Nama Karyawan : {karyawan.Nama}");
                Console.WriteLine($"Lama Kerja {karyawan.Nama} : {karyawan.LamaKerja} Bulan");
				Console.WriteLine($"Gaji Pokok {karyawan.Nama} : Rp.{karyawan.GajiPokok},00");
				Console.WriteLine($"Total Gaji {karyawan.Nama} : Rp.{karyawan.TotalGaji},00");
				Console.WriteLine();
			}
			
			Console.WriteLine();
			Console.WriteLine("Tekan ENTER untuk kembali ke Menu");
			Console.ReadLine();
			Console.Clear();
		}

		//Overloading dengan 2 fungsi yang sama dengan tampilDataGajiKaryawan tetapi parameter yang berbeda
		public static void TampilDataGajiKaryawan(List<Karyawan> karyawanList, string id)
		{
			Console.WriteLine();
			Console.WriteLine($"---------Lihat Data Gaji Berdasarkan ID : {id}---------");
			Console.WriteLine();

			foreach (var karyawan in karyawanList)
			{
				if (id == karyawan.Id)
				{
					Console.WriteLine($"ID Karyawan : {karyawan.Id}");
					Console.WriteLine($"Nama Karyawan : {karyawan.Nama}");
					Console.WriteLine($"Lama Kerja {karyawan.Nama} : {karyawan.LamaKerja} Bulan");
					Console.WriteLine($"Gaji Pokok {karyawan.Nama} : Rp.{karyawan.GajiPokok},00");
					Console.WriteLine($"Total Gaji {karyawan.Nama} : Rp.{karyawan.TotalGaji},00");
					Console.WriteLine();
				}
				else 
				{
					Console.WriteLine("ID Karyawan Tidak Ditemukan");
					Console.WriteLine();
				}
			}

			Console.WriteLine();
			Console.WriteLine("Tekan ENTER untuk kembali ke Menu");
			Console.ReadLine();
			Console.Clear();
		}

		public static void UbahDataGajiKaryawan(List<Karyawan> karyawanList)
		{
			Console.WriteLine();
			Console.WriteLine("---------Ubah Data Gaji Karyawan---------");
			Console.WriteLine("------------------------------------------");
			Console.WriteLine();
			
			Console.WriteLine("Masukkan ID Karyawan : ");
			string id = Console.ReadLine();
			Console.WriteLine();

			foreach (var karyawan in karyawanList)
			{
				if (id == karyawan.Id)
				{
					Console.WriteLine($"Data Karyawan Dengan ID : {karyawan.Id}");
					Console.WriteLine($"Nama Karyawan : {karyawan.Nama}");
					Console.WriteLine($"Lama Kerja {karyawan.Nama} : {karyawan.LamaKerja} Bulan");
					Console.WriteLine($"Gaji Pokok {karyawan.Nama} : Rp.{karyawan.GajiPokok},00");
					Console.WriteLine($"Total Gaji {karyawan.Nama} : Rp.{karyawan.TotalGaji},00");
					Console.WriteLine();

					Console.WriteLine("Masukkan Data Gaji Karyawan");
					Console.WriteLine();

					Console.Write("Lama Kerja (Bulan) : ");
					karyawan.LamaKerja = int.Parse(Console.ReadLine());

					Console.Write("Gaji Pokok : ");
					karyawan.GajiPokok = int.Parse(Console.ReadLine());

					karyawan.TotalGaji = karyawan.HitungGaji(karyawan.GajiPokok, karyawan.LamaKerja);

					Console.WriteLine();
					Console.Write("DATA GAJI KARYAWAN BERHASIL DIUBAH");
					Console.WriteLine();
					break;
				}
				else 
				{
					Console.WriteLine("ID Karyawan Tidak Ditemukan");
					Console.WriteLine();
				}
			}
			Console.WriteLine();
			Console.WriteLine("Tekan ENTER untuk kembali ke Menu");
			Console.ReadLine();
			Console.Clear();
		}

		public static void HapusDataGajiKaryawan(List<Karyawan> karyawanList)
		{
			Console.WriteLine();
			Console.WriteLine("---------Hapus Data Gaji Karyawan---------");
			Console.WriteLine("------------------------------------------");
			Console.WriteLine();
			
			Console.WriteLine("Masukkan ID Karyawan : ");
			
			string id = Console.ReadLine();
			Console.WriteLine();
			
			foreach (var karyawan in karyawanList)
			{
				if (id == karyawan.Id)
				{
					karyawanList.Remove(karyawan);
					
					Console.WriteLine();
					Console.Write("DATA GAJI KARYAWAN BERHASIL DIHAPUS");
					Console.WriteLine();
					break;
				}
				else 
				{
                    Console.WriteLine("Data Tidak Ditemukan");
					Console.WriteLine();
				}
			}
            Console.WriteLine();
            Console.WriteLine("Tekan ENTER untuk kembali ke Menu");
            Console.ReadLine();
			Console.Clear();
		}

		public static void Menu()
		{
			Console.WriteLine("==========MENU HITUNG GAJI KARYAWAN==========");
			Console.WriteLine("---------------------------------------------");
			Console.WriteLine("1.Input Data Gaji Karyawan");
			Console.WriteLine("2.Tampil Seluruh Data Gaji Karyawan");
			Console.WriteLine("3.Tampil Data Berdasarkan ID Karyawan");
			Console.WriteLine("4.Ubah Data Gaji Karyawan");
			Console.WriteLine("5.Hapus Data Gaji Karyawan");
			Console.WriteLine("6.Keluar Program");
			Console.Write("Masukkan Inputan Menu : ");
		}
	}
}