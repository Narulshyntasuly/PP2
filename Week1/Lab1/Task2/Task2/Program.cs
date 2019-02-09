using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name: "); // ввел имя
            string name = Console.ReadLine(); //создал переменную 
            Console.WriteLine("ID: ");
            string ID = Console.ReadLine();
            Student s = new Student("string _ID, string _name")
            s.infostudent(); // метод 

            string a = Console.ReadLine();
            if(a == "+") // когда ввожу слово ап увеличиваю год обучения
            {
                s.god(); 
                s.infostudent();
            }
        }
    }
    class Student
    {
        public string name;
        public int year;
        public string ID;
        public Student(string _ID,string _name)
        {
            ID = _ID; 
            name = _name;
            year = 1 ;
        }
        public void infostudent()
        {
            Console.WriteLine("Name: " + name); //вывод информации
            Console.WriteLine("Student id: " + ID);
            Console.WriteLine("Year of study: " + year);
        }
        public void god()
        {
            year++;
        }
    }
}