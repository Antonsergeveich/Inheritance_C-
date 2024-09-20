//#define WRITE_TO_FILE
#define READ_FROM_FILE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;// сам открывает фаил

namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if WRITE_TO_FILE //Пишем в файл
            StreamWriter sw = new StreamWriter("File.txt");
            sw.WriteLine("Hello files"); // пишем в поток
            sw.Close(); // После записи в поток его обязательно нужно закрыть
            Process.Start("notepad", "File.txt");// сам открывает фаил  
#endif

#if READ_FROM_FILE // Читаем из файла
            StreamReader sr = new StreamReader("File.txt");

            while (!sr.EndOfStream) 
            {
                string buffer = sr.ReadLine();
                Console.WriteLine(buffer);
            }

            sr.Close();
#endif
        }
    }
}
