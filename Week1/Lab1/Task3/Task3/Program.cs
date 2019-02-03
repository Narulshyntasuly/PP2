using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            string[] massiv = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(massiv[i]);
            }
            for(int i = 0; i < n; i++)
            {
                Console.Write("{0} {0} ",array[i]);
            }
                Console.ReadLine();
        }
    }
}
