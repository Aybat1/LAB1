using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Complex
    {
            public int a,b;
            public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public override string ToString()
        {
            return a + "/" + b;
        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            int num1, num2;
            if (c1.b == c2.b)
            {
                num1 = c1.a + c2.a;
                num2 = c2.b;
            }
            else
            {
                num1 = c1.a * c2.b + c2.a * c1.b;
                num2 = c1.b * c2.b;
            }
            if (num2 > num1)
            {
                for(int i= num2; i > 1; i--)
                {
                    if(num1%i==0 && num2 % i == 0)
                    {
                        num1 = num1 / i;
                        num2 = num2 / i;
                    }
                }
            }
            else
            {
                for(int i= num1;i>1;i--)
                {
                    if(num1%i==0 && num2 % i == 0)
                    {
                        num1 = num1 / i;
                        num2 = num2 / i;
                    }

                }
            }

            Complex c3 = new Complex(num1,num2);
            return c3;
        }   

    }
    class Program
    {
        static void Main(string[] args)
        {
            
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string[] num1 = first.Split('/');
            // 7/9  num1[0]='7'; num1[1]='9'
            //1/6 num2[0]='1'; num2[1]='6'

            string[] num2 = second.Split('/');
            Complex c = new Complex(Convert.ToInt32(num1[0]), Convert.ToInt32(num1[1]));
            Complex d = new Complex(Convert.ToInt32(num2[0]), Convert.ToInt32(num2[1]));
            //Complex c = new Complex('7'-------7, '9'--------9)
            //Complex d = new Complex('1'-------1, '6'--------6)
            Complex w = c + d;
            Console.WriteLine(w);
            Console.ReadKey();
         }
    }
}
