using System;
using System.Collections.Generic;

namespace DTSMCC
{
    class Program
    {
        static List<string[]> surat = new List<string[]>();

        static void Main(string[] args)
        {
            int pilihan;
            
            do
            {
                TampilanMenu();
                pilihan = Int32.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (pilihan)
                {
                    case 1:

                        string nomorSurat = inputSurat();
                        Console.WriteLine("\nSurat dengan nomor surat " + nomorSurat + " berhasil diinput!\n\n");
                        break;
                    case 2:
                        Console.WriteLine("\n---- Daftar Surat ----");
                        foreach (var i in surat)
                        {
                            
                            Console.WriteLine("Nomor Surat\t\t: " + i[0]);
                            Console.WriteLine("Kode Surat\t\t: " + i[1]);
                            Console.WriteLine("Asal Surat\t\t: " + i[2]);
                            Console.WriteLine("Perihal Surat\t\t: " + i[3] + "");
                            Console.WriteLine("---------------------------------\n");
                        }
                        break;
                    case 3:
                        break;

                    default:
                        break;
                }

            } while (pilihan != 3);
        }

        static void TampilanMenu()
        {
            Console.WriteLine("==== Sistem Penginputan Surat ====");
            Console.WriteLine("Menu Pilihan: ");
            Console.WriteLine("1. Input Surat");
            Console.WriteLine("2. Lihat Daftar Surat");
            Console.WriteLine("3. Exit");
            Console.Write("Silahkan input nomor menu yang dituju: ");
        }

        static string inputSurat()
        {
            string[] tempSurat = new string[4];
            Console.WriteLine("==== Input Surat ====");
            Console.Write("Masukkan nomor surat\t\t: ");
            tempSurat[0] = Console.ReadLine();
            Console.Write("Masukkan kode surat\t\t: ");
            tempSurat[1] = Console.ReadLine();
            Console.Write("Masukkan asal surat\t\t: ");
            tempSurat[2] = Console.ReadLine();
            Console.Write("Masukkan perihal surat\t\t: ");
            tempSurat[3] = Console.ReadLine();

            surat.Add(tempSurat);

            return tempSurat[0];
        }


        
        
    }
}
