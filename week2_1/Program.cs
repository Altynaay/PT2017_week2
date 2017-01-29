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
        static bool isPrime(int a) // проверяет простое ли число
        {
            if (a == 1)
                return false;
            for (int i = 2; i * i < a; i++)
                if (a % i == 0)
                    return false;
            return true;
        }
        static void Pr1()
        {
            StreamReader sr = new StreamReader(@"C:\Users\Admin\Documents\input.txt"); // считывает данные с указанног файла 
            StreamWriter sw = new StreamWriter(@"C:\Users\Admin\Documents\output.txt"); // записывает полученный результат в файл 
            string[] arr = sr.ReadLine().Split(); // записывает данные в массив стрингов 
            int x = 99999;
            foreach (string s in arr)
            {
                int p = int.Parse(s); //  переводит в инты стринги 
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