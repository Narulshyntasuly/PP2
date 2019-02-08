using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static bool Palindrom(string pal) // метод проверяющий палиндромность
        {
            for (int i = 0; i < pal.Length; i++) 
            {
                if (pal[i] != pal[pal.Length - i - 1]) // проверерка
                {
                    return false;
                }
            }
            return true;
        }

            
        static void Main(string[] args)
        {
            string pal = Console.ReadLine(); 
            if (!Palindrom(pal))    // проверка строки методом палиндром
            {
                Console.WriteLine("NO");

            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
