using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_1_1214081
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ANAK AYAM TURUN 10");
            int angka = int.Parse(Console.ReadLine());
            if (angka > 10 || angka <=0)
            {
                Console.WriteLine("Angka tidak sesuai");
            }
            else
            {
                for (int n = angka; n > 0; n--)
                {

                    if (n == 1)
                    {
                        Console.WriteLine("Anak ayam turunlah 1, mati satu tinggal Induknya");
                    }
                    else
                    {
                        Console.WriteLine("Anak ayam turunlah " + n + ", mati satu tinggal " + (n - 1));
                    }
                }
            }
            
        }
    }
}
