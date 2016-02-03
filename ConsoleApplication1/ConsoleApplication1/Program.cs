using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, b, i,k;
            n = 0;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            for(i= a;i<= b;i++)
            {
                for(k=1;k<=i;k++)
                {
                    if (i % k == 0)
                        n++;
                }
                if(n<=2)
                {
                    Console.Write("{0} ", i);
                   
                }
                n = 0;
               
            }
            Console.ReadKey();
            
        }
    }
}
