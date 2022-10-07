using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_1214085
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                var start = true;
                while (start)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Menu Persegi Panjang");
                    Console.WriteLine("1. Hitung Luas");
                    Console.WriteLine("2. Hitung Keliling");
                    Console.WriteLine(" ");

                    Console.Write("Menu Pilihan : ");
                    string pilihan = Console.ReadLine();

                    Console.WriteLine(" ");

                    switch (pilihan)
                    {
                        case "1":
                            Console.WriteLine("MENGHITUNG LUAS PERSEGI PANJANG ");
                            Console.Write("Masukan panjang : ");
                            var panjang = int.Parse(Console.ReadLine());
                            Console.Write("Masukan lebar : ");
                            var lebar = int.Parse(Console.ReadLine());
                            var luas = panjang * lebar;
                            Console.WriteLine(" ");
                            Console.WriteLine("Luas dari persegi panjang adalah " + luas);
                            break;

                        case "2":
                            Console.WriteLine("MENGHITUNG KELILING PERSEGI PANJANG");
                            Console.Write("Masukan panjang : ");
                            var panjang2 = int.Parse(Console.ReadLine());
                            Console.Write("Masukan lebar : ");
                            var lebar2 = int.Parse(Console.ReadLine());
                            int keliling = (panjang2 * 2) + (lebar2 * 2);
                            Console.WriteLine(" ");
                            Console.WriteLine("Keliling dari persegi panjang adalah " + keliling);
                            break;
                            
                    }
                    Console.WriteLine(" ");
                    Console.Write("ApakaH Anda Ingin Mengulangi Lagi? (Y/T) : ");
                    var input = Console.ReadLine();
                    if (input == "T")
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Program Telah Berakhir");
                        start = false;
                    }
                    else if (input == "Y")
                    {
                        start = true;
                    }
                    else
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Input Tidak Valid");
                        start = false;
                    }

                }
            }
        }
    }
}
