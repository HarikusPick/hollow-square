using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Uzun Kenarı Giriniz=");
            int uzun = int.Parse(Console.ReadLine());
            Console.Write("Kısa Kenarı Giriniz=");
            int kisa = int.Parse(Console.ReadLine());
            Console.Write("Karakteri Giriniz=");
            string karakter = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            for (int i = 0; i < uzun; i++)
            {
                for (int j = 0; j < kisa; j++)
                {
                    if (i == 0 || j == 0 || i == uzun - 1 || j == kisa - 1)
                    {
                        Console.Write(karakter);
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
