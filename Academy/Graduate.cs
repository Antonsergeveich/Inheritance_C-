using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Graduate:Student
    {
        public string Subject { get; set; }
        public Graduate
            (
            string lastName, string firstName, uint age,
            string speciality, string group, double rating, double attendance,
            string subject
            ):base(lastName, firstName, age, speciality, group, rating, attendance)
        {
            Subject = subject;
            Console.WriteLine($"GConstructor:\t{GetHashCode()}");
        }
        
        public Graduate(Student student, string subject) : base(student)
        { 
            Subject = subject; 
            Console.WriteLine($"GConstructor:\t{GetHashCode()}");
        }

        public Graduate(Human human, string speciality, string group, double rating, double attendance) : base(human, speciality, group, rating, attendance)
        {
            Console.WriteLine($"GConstructor:\t{GetHashCode()}");
        }
        public Graduate(Human human, string speciality, string group, double rating, double attendance, string subject) : base(human, speciality, group, rating, attendance)
        {
            this.Subject = subject;
            Console.WriteLine($"GConstructor:\t{GetHashCode()}");
        }

        ~Graduate()
        {
            Console.WriteLine($"GDestructor:\t{GetHashCode()}");
        }
        public override string ToString()
        {
            return base.ToString() + $" {Subject}";
        }

    }
}
