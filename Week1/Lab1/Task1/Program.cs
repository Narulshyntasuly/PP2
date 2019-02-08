using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Prime(int[] a) 
        {
            int cnt = 0;
            bool ok;
            string zhai = "";    
            // этот цикл проверяет число на простоту
            for (int i = 0; i < a.Length; i++)
            {
                ok = true;
                int k = 2;
                while (k < a[i])
                {
                    if (a[i] % k == 0)
                    {
                        ok = false;
                        break;
                    }
                    k++;
                }
                if (ok == true && a[i] != 1)
                {
                    cnt++;
                    zhai = zhai + a[i] + " ";
                }

            }
            // если нет простых чисел тогда показываем 0биначе показываем каунтер и строку жай
            if (cnt != 0)
            {
                Console.WriteLine(cnt);
                Console.WriteLine(zhai);
            }
            else
            {
                Console.WriteLine(cnt);
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // длинна массива
            int[] array = new int[n]; // сам массив 
            string[] cusoc = Console.ReadLine( ).Split(); // массив  разделенный по кусочкам с помощью метода сплит
            for(int i = 0; i < n; i++)
            {
                array[i] = int.Parse(cusoc[i]); // перевожу из массива кусок в массив эрей
            }
            Prime(array); // метод прайм
        }

    }
}
