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
         static void Pr1()
         { // считывает данные с указанного файла 
             StreamReader sr = new StreamReader(@"C:\Users\Admin\Documents\input.txt");
             string[] arr = sr.ReadLine().Split(); //записывает данные с файла в массив в виде стрингов 
             int min = 99999, max = -99999;
             foreach (string s in arr)
            {
                 int p = int.Parse(s); //переводит стринги в инты 
                 if (p<min)
                     min = p;
                 if (p > max)
                     max = p;
             }
             Console.WriteLine(min + " " + max); //выводит на экран маскимальное и минимальное числа через пробел 
             Console.ReadKey();
             sr.Close();
         }
         static void Main(string[] args)
         {
             Pr1();
         }
    }
 }
