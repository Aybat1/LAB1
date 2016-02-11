using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;


namespace набор_чисел
{
    class Program
    {
        static void Main(string[] args)
        {
            Read();

        }


        public static void Create()
        {
            FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("2 56 78 1 97 85 32");
            sw.Close();
            fs.Close();
        }


        public static void Read()
        {
            FileStream fs1 = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs1);

            string a = sr.ReadToEnd();
            Console.WriteLine(a);
            string[] n = a.Split();
            int max = Convert.ToInt32(n[0]);
            int min = Convert.ToInt32(n[0]);
            for (int i = 0; i < n.Length; i++)   
            {

                if (Convert.ToInt32(n[i]) > max)
                {
                    max = Convert.ToInt32(n[i]);
                }
                if (Convert.ToInt32(n[i]) < min)
                {
                    min = Convert.ToInt32(n[i]);
                }

            }
            Console.WriteLine("Min: {0}", min);
            Console.WriteLine("Max: {0} ", max);
            sr.Close();
            fs1.Close();
            Console.ReadKey();
        }
    }
}
