using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Рекурсия
{
    class Program
    {
        static void Main(string[] args)
        {
            Search(@"C:\Games");
        }
        static void Search(string abr)
        {
            Stack<string> stack = new Stack<string>();
            Console.WriteLine(abr + ":" + Directory.GetFiles(abr).Length);
            stack.Push(abr);
            while (stack.Count > 0)
            {
                string abc = stack.Pop();
                string[] qwe = Directory.GetDirectories(abc);
                foreach (string str in qwe)
                {
                    Console.WriteLine(str + ":" + Directory.GetFiles(str).Length);
                    stack.Push(str);
                }
            }
            Console.ReadKey();
        }
    }
}
