//#define INHERITANCE_1
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
#if INHERITANCE_1
            Human human = new Human("Vercetty", "Tommy", 30);
            Console.WriteLine(human);

            Student student = new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 95, 96);
            Console.WriteLine(student);

            Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 25);
            Console.WriteLine(teacher); 
#endif
            Human tommy = new Human("Vercetty", "Tommy", 30);
            Console.WriteLine(tommy);

            Student student_tommy = new Student(tommy, "Theft", "Vice", 95, 98);
            Console.WriteLine(student_tommy);

            Graduate graduate_tommy = new Graduate(student_tommy, "Working in a printing_house");
            Console.WriteLine(graduate_tommy);

            Human ricardo = new Human("Diaz", "Ricardo", 50);
            Console.WriteLine(ricardo);

            Teacher teacher_ricardo = new Teacher(ricardo, "Weapons distribution", 20);
            Console.WriteLine(teacher_ricardo);

            Human lance = new Human("Vance", "Lance", 30);
            Console.WriteLine(tommy);

            Student student_lance = new Student(lance, "Helicopter driving", "Vice City", 55, 93);
            Console.WriteLine(student_tommy);

            Graduate graduate_lance = new Graduate(lance, "Helicopter_driving", "Vice_City", 95, 98, "Money");
            Console.WriteLine(graduate_lance);
            
            Graduate bachelor_lance = new Graduate(student_lance, "Money");
            Console.WriteLine(graduate_lance);

            
        }
    }
}
