﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task22
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream Numbers = new FileStream(@"C:\Users\80443\Desktop\Lab\Real.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(Numbers);
            FileStream Num = new FileStream(@"C:\Users\80443\Desktop\Lab\Barselona.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(Num);
            string x = sr.ReadLine();
            int cnt = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == ' ')
                {
                    cnt++;
                }
            }
            string[] N = x.Split(' ');
            for (int i = 0; i < cnt + 1; i++)
            {
                bool m = true;
                int a = int.Parse(N[i]);

                for (int j = 2; j < cnt + 1; j++)
                {
                    if (a % j == 0)
                    {
                        m = false;
                    }
                }
                if(a > 1 && m == true)
                {
                    
                    sw.Write(a + " ");
                }
            }
        
            sw.Close();
            Numbers.Close();
            sr.Close();
            Num.Close();
        }
    }
}
