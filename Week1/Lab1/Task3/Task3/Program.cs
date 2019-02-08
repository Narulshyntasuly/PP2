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
            int n = int.Parse(Console.ReadLine()); //длинна массива
            int[] array = new int[n]; // наш массив
            string[] massiv = Console.ReadLine().Split(); //массив из стрингов разделенный с помощью метода сплит
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(massiv[i]); //переводим элементы массива в виде строк в вид инт с помощью парс
            }
            for(int i = 0; i < n; i++)
            {
                Console.Write("{0} {0} ",array[i]); //двойной вывод элементов массива с помощью своиства метода райт //козырь
            }
            Console.WriteLine();
        }
    }
}
