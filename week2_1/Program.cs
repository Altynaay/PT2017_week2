using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        class Complex
        {
            public int a, b;
            public Complex(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
            public override string ToString()
            {
                return a + "/" + b;
            }
            public static Complex operator +(Complex a, Complex b)
            {
                Complex p = new Complex(a.a * b.b + a.b * b.a, a.b * b.b);
                return p;
            }
        }
        static void Main(string[] args)
        {
            Complex a = new Complex(1, 2);
            Complex b = new Complex(1, 3);
            Complex c = a + b;
            Console.WriteLine(c);
            Console.ReadKey();

        }
    }
}
