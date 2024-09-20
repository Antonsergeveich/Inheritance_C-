using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Vercetty", "Tommy", 30);
            Console.WriteLine(human);

            Student student = new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 95, 96);
            Console.WriteLine(student);
        }
    }
}
