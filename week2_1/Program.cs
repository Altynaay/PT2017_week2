﻿using System;
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
                this.a = a; // присваивает экземпляру а значение инт а 
                this.b = b;
            }
            public override string ToString() 
            {
                return a + "/" + b; // выводит на экран комплексное число через дробь 
            }
            public static Complex operator +(Complex a, Complex b) // перегрузка оператора +
            {
                Complex p = new Complex(a.a * b.b + a.b * b.a, a.b * b.b);
                return p;
            }
            public static Complex operator -(Complex a, Complex b)
            {
                Complex m = new Complex(a.a * b.b - a.b * b.a, a.b * b.b);
                return m;
            }

        }
        static void Main(string[] args)
        {
            Complex a = new Complex(1, 2);
            Complex b = new Complex(1, 3);
            Complex c = a + b;
            Complex d = a - b;

            Console.WriteLine(c);
            Console.ReadKey();

        }
    }
}