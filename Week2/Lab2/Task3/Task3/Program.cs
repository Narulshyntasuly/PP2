using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        static void WalkDirectoryTree(DirectoryInfo root, int lvl)
        {
            FileInfo[] files = root.GetFiles();
            DirectoryInfo[] directories = root.GetDirectories();

            foreach (DirectoryInfo d in directories)
            {
                for (int i = 0; i < lvl; ++i) Console.Write(" ");
                Console.WriteLine(d.Name);
                WalkDirectoryTree(d, lvl + 3);
            }
            foreach (FileInfo file in files)
            {
                for (int i = 0; i < lvl; ++i) Console.Write(" ");
                Console.WriteLine(file.Name);
            }

        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            DirectoryInfo ds = new DirectoryInfo("C:/Users/lenovo/Desktop/check");
            WalkDirectoryTree(ds, 0);
            //Console.ReadKey(); Console.WriteLine("Press any key to close this window...");
            Console.ReadKey();
        }
    }
}