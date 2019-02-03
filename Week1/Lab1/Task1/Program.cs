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
            int n = int.Parse(Console.ReadLine()); 
            int[] array = new int[n];
            string line = Console.ReadLine();
            string[] cusoc = line.Split();
            for(int i = 0; i < n; i++)
            {
                array[i] = int.Parse(cusoc[i]);
            }
            Prime(array);
        }

    }
}
