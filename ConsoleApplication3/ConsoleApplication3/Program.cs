using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Student
    {
        public string name;
        public string surname;
        public string ID;
        public double GPA;
        public Student(string name, string surname, string ID, double GPA)
        {
            this.name = name;
            this.surname = surname;
            this.ID = ID;
            this.GPA = GPA;
        }

        public override string ToString()
        {
            return name + " " + surname + " " + ID + " " + GPA;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            string a, b, c;
            double d;
            Console.WriteLine("How many students you want involve?");
            int count = int.Parse(Console.ReadLine());
            Student[] infor = new Student[count];
            for (int i = 0; i < count; i++)
            {
                try
                {
                    Console.WriteLine("Write the first name");
                    a = Console.ReadLine();
                    Console.WriteLine("Write the second name");
                    b = Console.ReadLine();
                    Console.WriteLine("Write the your id");
                    c = Console.ReadLine();
                    Console.WriteLine("Write the your gpa");
                    d = double.Parse(Console.ReadLine());
                    infor[i] = new Student(a, b, c, d);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.ReadKey();
                }

            }
            Console.WriteLine("Enter 1 to see all list , enter 2 to see gpa only");
            ConsoleKeyInfo button = Console.ReadKey();
            if (button.Key == ConsoleKey.NumPad1)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(infor[i]);
                }
                Console.ReadKey();
            }
            else if(button.Key==ConsoleKey.NumPad2)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Name : {0} GPA : {1}",infor[i].name,infor[i].GPA);
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Good buy");
                Console.ReadKey();
            }
        }
    }
}
    