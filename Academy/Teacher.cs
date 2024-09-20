using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Teacher : Human
    {
        public string Speciality { get; set; }
        public uint Experience { get; set; }
        public Teacher
            (
            string lastName, string firstName, uint age,
            string speciality, uint experience
            ) : base(lastName, firstName, age)
        {
            Speciality = speciality;
            Experience = experience;
            Console.WriteLine($"TConstructor:\t{GetHashCode()}");
        }
        ~Teacher()
        {
            Console.WriteLine($"TDestructor:\t{GetHashCode()}");
        }
        public override string ToString()
        {
            return base.ToString()+ $" {Speciality} {Experience}";
        }
    }
}
