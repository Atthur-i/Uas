using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Parkiran Amikom";

            int pilihan;
            List<Kendaraan> listkendaraan = new List<Kendaraan>();
            do
            {
                Console.Clear();
                Console.WriteLine("Pilih Menu Aplikasi");
                Console.WriteLine();
                Console.WriteLine("1. Kendaraan Masuk");
                Console.WriteLine("2. Kendaraan Keluar");
                Console.WriteLine("3. Tampilkan Kendaraan");
                Console.WriteLine("4. Keluar");
                Console.WriteLine();
                Console.Write("Nomor Menu [1..4] : ");
                pilihan = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (pilihan)
                {
                    case 1:
                        Console.WriteLine("Kendaraan Masuk\n");
                        Console.Write("Jenis Kendaraan [1. Sepeda, 2. Motor, 3. Mobil] : ");
                        int pil = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        switch (pil)
                        {
                            case 1:
                                Sepeda sepeda = new Sepeda();
                                Console.Write("No. Kendaraan : ");
                                sepeda.NoKen = Console.ReadLine();
                                listkendaraan.Add(sepeda);
                                break;
                            case 2:
                                Motor motor = new Motor();
                                Console.Write("No. Kendaraan : ");
                                motor.NoKen = Console.ReadLine();
                                listkendaraan.Add(motor);
                                break;
                            case 3:
                                Mobil mobil = new Mobil();
                                Console.Write("No. Kendaraan : ");
                                mobil.NoKen = Console.ReadLine();
                                listkendaraan.Add(mobil);
                                break;
                            default:
                                Console.WriteLine("Menu Yang Anda Masukkan Salah!!!");
                                break;
                        }
                        break;
                    case 2:
                        int no = -1, hapus = -1;
                        Console.WriteLine("Kendaraan Keluar\n");
                        Console.Write("No. Kendaraan : ");
                        string noken = Console.ReadLine();
                        foreach (Kendaraan kendaraan in listkendaraan)
                        
                            {
                                no++;
                                if (kendaraan.NoKen == noken)
                                {
                                    Console.Write("Berapa jam kendaraan parkir : ");
                                kendaraan.Jam = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Jumlah yang harus dibayar : Rp. {0}.", kendaraan.Biaya());
                                    hapus = no;
                                }
                            }
                            if (hapus != -1)
                            {
                                listkendaraan.RemoveAt(hapus);
                            }
                            else
                            {
                                Console.WriteLine("\nKendaaraan tidak ditemukan");
                            }
                        
                        break;
                    case 3:
                        int nourut = 0;
                        string jenis = " ";
                        Console.WriteLine("Data Kendaraan : \n");
                        foreach (Kendaraan kendaraan in listkendaraan)
                        {
                            if (kendaraan is Sepeda)
                            {
                                jenis = "Sepeda";
                            }
                            else if (kendaraan is Motor)
                            {
                                jenis = "Motor";
                            }
                            else
                            {
                                jenis = "Mobil";
                            }
                            nourut++;
                            Console.WriteLine("{0}. Jenis Kendaraan: {1}, No. Kendaraan : {2},", nourut, jenis, kendaraan.NoKen );
                        }
                        if (nourut < 1)
                        {
                            Console.WriteLine("Parkiran Kosong");
                        }
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Menu Yang  Di Masukkan Salah!!!");
                        break;
                }
                Console.WriteLine("\n\nTekan Enter untuk kembali ke Menu");
                Console.ReadKey();
            }
            while (pilihan != 4);
        }
    }
}