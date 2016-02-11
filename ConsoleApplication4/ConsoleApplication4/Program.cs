using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Read();
        }
        public static void Otvet(int answer)
        {
            FileStream fs = new FileStream("output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(answer);
            sw.Close();
            fs.Close();
            Console.ReadKey();
        }
        public static void Read()
        {
            FileStream fs1 = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sd = new StreamReader(fs1);
            string q = sd.ReadToEnd();
            Console.WriteLine(q);
            string[] nums = q.Split();
            int n = 0, a = 0;
            int[] array = new int[nums.Length];
            for(int i = 0; i < nums.Length; i++)
            {
                array[i] = int.Parse(nums[i]);
            }
            for(int i = 0; i < array.Length-1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    n = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = n;
                }

            }
            for(int i = 0; i < array.Length; i++)
            {
                int c = 0;
                for(int j = 1; j < array.Length; j++)
                {
                    if (array[i] % j == 0)
                    {
                        c++;
                    }
                }
                if (c <= 2)
                {
                    a = array[i];
                    break;
                }
            }
            Otvet(a);
            fs1.Close();
            sd.Close();
        } 
    }
}
