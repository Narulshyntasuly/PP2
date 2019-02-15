using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp22
{


    enum Manual { Folder = 1, File = 2 }


    class Forselect
    {
        public DirectoryInfo[] FolCon
        {
            get;
            set;
        }
        public FileInfo[] FileCon
        {
            get;
            set;
        }
        public int selectedIndex
        {
            get;
            set;
        }


        public void Paint()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < FolCon.Length; i++)
            {
                if (i == selectedIndex)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(i + 1 + ". " + FolCon[i].Name);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int j = 0; j < FileCon.Length; j++)
            {
                if (j + FolCon.Length == selectedIndex)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(j + FolCon.Length + 1 + ". " + FileCon[j].Name);
            }
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo Barca = new DirectoryInfo(@"C:\Users\80443\Desktop\Lab");
            Forselect Far = new Forselect { FolCon = Barca.GetDirectories(), FileCon = Barca.GetFiles(), selectedIndex = 0 };
            Far.Paint();

            Manual book = Manual.Folder;
            Stack<Forselect> Window = new Stack<Forselect>();
            Window.Push(Far);
            bool job = false;
            while (!job)
            {
                if (book == Manual.Folder)
                {
                    Window.Peek().Paint();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Open: Enter || Back: Backspace || Deleted: Delete || Rename:R || End: Escape");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                ConsoleKeyInfo klavish = Console.ReadKey();
                switch (klavish.Key)
                {
                    case ConsoleKey.DownArrow:
                        if (Window.Peek().selectedIndex < Window.Peek().FolCon.Length + Window.Peek().FileCon.Length - 1)
                        {
                            Window.Peek().selectedIndex++;
                        }
                        else
                        {
                            Window.Peek().selectedIndex = 0;
                        }
                        break;


                    case ConsoleKey.UpArrow:
                        if (Window.Peek().selectedIndex > 0)
                        {
                            Window.Peek().selectedIndex--;
                        }
                        else
                        {
                            Window.Peek().selectedIndex = Window.Peek().FolCon.Length + Window.Peek().FileCon.Length - 1;
                        }
                        break;


                    case ConsoleKey.Enter:
                        int ind = Window.Peek().selectedIndex;
                        int FO = Window.Peek().FolCon.Length;

                        if (ind < FO)
                        {
                            DirectoryInfo Real = new DirectoryInfo(Window.Peek().FolCon[ind].FullName);
                            Forselect Far1 = new Forselect() { FolCon = Real.GetDirectories(), FileCon = Real.GetFiles(), selectedIndex = 0 };
                            Window.Push(Far1);
                        }

                        else
                        {
                            book = Manual.File;
                            FileStream fs = new FileStream(Window.Peek().FileCon[ind - FO].FullName, FileMode.Open, FileAccess.Read);
                            StreamReader sr = new StreamReader(fs);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            string x = sr.ReadLine();
                            Console.WriteLine(x);
                            sr.Close();
                            fs.Close();
                        }
                        break;

                    case ConsoleKey.Backspace:
                        if (book == Manual.Folder)
                        {
                            Window.Pop();
                        }
                        else
                        {
                            book = Manual.Folder;
                        }
                        break;

                    case ConsoleKey.Escape:
                        job = true;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Blue;

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("work is done");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;

                    case ConsoleKey.Delete:
                        ind = Window.Peek().selectedIndex;
                        FO = Window.Peek().FolCon.Length;

                        if (ind < FO)
                        {
                            Directory.Delete(Window.Peek().FolCon[ind].FullName);
                        }
                        else
                        {
                            File.Delete(Window.Peek().FileCon[ind - FO].FullName);
                        }
                        Window.Pop();
                        if (Window.Count() == 0)
                        {
                            Forselect Far2 = new Forselect { FolCon = Barca.GetDirectories(), FileCon = Barca.GetFiles(), selectedIndex = 0 };
                            Window.Push(Far2);
                        }
                        else
                        {
                            DirectoryInfo Chelsea = new DirectoryInfo(Window.Peek().FolCon[ind].FullName);
                            Forselect Far3 = new Forselect() { FolCon = Chelsea.GetDirectories(), FileCon = Chelsea.GetFiles(), selectedIndex = 0 };
                            Window.Push(Far3);
                        }
                        break;

                    case ConsoleKey.R:
                        ind = Window.Peek().selectedIndex;
                        FO = Window.Peek().FolCon.Length;

                        string name;
                        string fullname;
                        int indexMode;

                        if (ind < FO)
                        {
                            name = Window.Peek().FolCon[ind].Name;
                            fullname = Window.Peek().FolCon[ind].FullName;
                            indexMode = 1;
                        }
                        else
                        {
                            name = Window.Peek().FileCon[ind - FO].Name;
                            fullname = Window.Peek().FileCon[ind - FO].FullName;
                            indexMode = 2;
                        }
                        string newfullname = fullname.Remove(fullname.Length - name.Length);

                        Console.WriteLine("ename : please change the name");
                        string newname = Console.ReadLine();
                        if (indexMode == 1)
                        {
                            new DirectoryInfo(Window.Peek().FolCon[ind].FullName).MoveTo(newfullname + newname);
                        }
                        else
                        {
                            new FileInfo(Window.Peek().FileCon[ind - FO].FullName).MoveTo(newfullname + newname);
                        }
                        Window.Pop();
                        if (Window.Count() == 0)
                        {
                            Forselect Far2 = new Forselect { FolCon = Barca.GetDirectories(), FileCon = Barca.GetFiles(), selectedIndex = 0 };
                            Window.Push(Far2);
                        }
                        else
                        {
                            DirectoryInfo Chelsea = new DirectoryInfo(Window.Peek().FolCon[ind].FullName);
                            Forselect Far3 = new Forselect() { FolCon = Chelsea.GetDirectories(), FileCon = Chelsea.GetFiles(), selectedIndex = 0 };
                            Window.Push(Far3);
                        }
                        break;
                }
            }
        }
    }
}
