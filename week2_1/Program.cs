using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Student
{
    class MainClass
    {
        static bool isPrime(int a)
        {   if (a == 1)
                return false;
            for (int i = 2; i * i < a; i++)
                if (a % i == 0)
                    return false;
            return true;
        }
        static void Pr1()
        {
            StreamReader sr = new StreamReader(@"C:\Users\Admin\Documents\input.txt");
            StreamWriter sw = new StreamWriter(@"C:\Users\Admin\Documents\output.txt");
            string[] arr = sr.ReadLine().Split();
            int x = 99999;
            foreach (string s in arr)
            {
                int p = int.Parse(s);
                if (isPrime(p))
                  if (p < x)
                      x = p;
            }
            sw.WriteLine(x);
            sw.Close();
            sr.Close();
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Pr1();
        }
    }
}

