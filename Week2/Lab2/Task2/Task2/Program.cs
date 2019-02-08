using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            string[] s = sr.ReadToEnd().Split();
            sr.Close();
            List<int> ans = new List<int>();
            for (int it = 0; it < s.Count(); it++)
            {
                int a = int.Parse(s[it]);
                int prime = 1;
                for (int i = 2; i <= (int)Math.Sqrt(a) && prime == 1; i++)
                    if (a % i == 0)
                        prime = 0;
                if (a != 1 && prime == 1)
                    ans.Add(a);
            }
            StreamWriter sw = new StreamWriter("output.txt");
            for (int i = 0; i < ans.Count(); i++)
                sw.Write(ans[i] + " ");
            sw.Close();
            Console.ReadKey();
        }
    }
}
    }
}
