using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_714240033
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool lanjut = true;

            do
            {
                Console.WriteLine("=== MENU PERSEGI PANJANG ===");
                Console.WriteLine("1. Hitung Luas");
                Console.WriteLine("2. Hitung Keliling");
                Console.WriteLine("3. Keluar");
                Console.Write("Pilih menu (1-3): ");

                string inputPilihan = Console.ReadLine();
                int pilihan;

                if (int.TryParse(inputPilihan, out pilihan))
                {
                    switch (pilihan)
                    {
                        case 1:
                            HitungLuas();
                            break;
                        case 2:
                            HitungKeliling();
                            break;
                        case 3:
                            lanjut = false;
                            break;
                        default:
                            Console.WriteLine("\nMenu tidak tersedia. Silakan pilih menu yang valid.");
                            break;
                    }

                    if (lanjut)
                    {
                        while (true)
                        {
                            Console.Write("\nIngin mengulang kembali (Y/T)? ");
                            string ulangi = Console.ReadLine();

                            if (ulangi.ToUpper() == "Y")
                            {
                                lanjut = true;
                                break;
                            }
                            else if (ulangi.ToUpper() == "T")
                            {
                                lanjut = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Input tidak valid. Harap masukkan Y atau T.");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nInput salah! Harap masukkan angka. Tekan Enter untuk mencoba lagi...");
                    Console.ReadLine();
                }

            } while (lanjut);

            Console.WriteLine("\nTerima kasih!");
        }

        static void HitungLuas()
        {
            double panjang = GetInputAngka("Masukkan panjang: ");
            double lebar = GetInputAngka("Masukkan lebar: ");
            double luas = panjang * lebar;
            Console.WriteLine($"Luas Persegi Panjang: {luas}");
        }

        static void HitungKeliling()
        {
            double panjang = GetInputAngka("Masukkan panjang: ");
            double lebar = GetInputAngka("Masukkan lebar: ");
            double keliling = 2 * (panjang + lebar);
            Console.WriteLine($"Keliling Persegi Panjang: {keliling}");
        }

        static double GetInputAngka(string prompt)
        {
            double angka;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (double.TryParse(input, out angka) && angka > 0)
                {
                    return angka;
                }
                else
                {
                    Console.WriteLine("Input tidak valid. Harap masukkan angka positif.");
                }
            }
        }
    }
}
