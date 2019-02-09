using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task44
{
    class Program
    {
        static void Main(string[] args)
        {

            string file1 = @"C:\Users\80443\Desktop\Lab\Path\GB.txt";
            string file2 = @"C:\Users\80443\Desktop\Lab\Path1\GB.txt";

            if (File.Exists(@"C:\Users\80443\Desktop\Lab\Path\GB.txt"))
            {
                Console.WriteLine("File exist");
            }
            else
                Console.WriteLine("You can not do this operation");

            File.Copy(file1, file2);
            Console.WriteLine("Copied");

            if (File.Exists(@"C:\Users\80443\Desktop\Lab\Path\GB.txt"))
            {
                try
                {
                    File.Delete(@"C:\Users\80443\Desktop\Lab\Path\GB.txt");
                }
                catch (IOException)
                {
                    Console.WriteLine("Exception");
                    return;
                }
            }
            Console.WriteLine("Original File Deleted");
        }
    }
}
