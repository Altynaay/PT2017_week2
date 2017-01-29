using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Rcr(string path, int level)
            //вывести папки и файлы до второго уровня 
        {  
            if (level > 2)
                return;
                DirectoryInfo directory = new DirectoryInfo(path);
                FileInfo[] files = directory.GetFiles();
                DirectoryInfo[] directories = directory.GetDirectories();
                //вывести названия всех файлов 
                foreach (FileInfo file in files)
                {
                    emptySpace(level);
                    Console.WriteLine(file.Name);
                }
                // вывести названия всех папок с пробелом 
                foreach (DirectoryInfo dInfo in directories)
                {
                    emptySpace(level);
                    Console.WriteLine(dInfo.Name);
                    Rcr(dInfo.FullName, level + 1);
                }
         }
        static void Main(string[] args)
        {
            Rcr(@"C:\Users\Admin", 0);
        }
    }
}
