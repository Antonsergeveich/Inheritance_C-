using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("File.txt");
            sw.WriteLine("Hello files");
            sw.Close();
            Process.Start("notepad", "File.txt");
        }
    }
}
