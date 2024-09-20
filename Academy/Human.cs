using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Human
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public uint Age { get; set; }
        public Human(string lastName, string firstName, uint age)
        {
            LastName = lastName;
            FirstName = firstName;
            Age = age;
            Console.WriteLine($"HConstructor:\t{GetHashCode()}");
        }
        public Human(Human other)
        {
            this.LastName = other.LastName;
            this.FirstName = other.FirstName;
            this.Age = other.Age;
            Console.WriteLine($"HCopyConstructor:\t{GetHashCode()}");
        }
        ~Human() 
        {
            Console.WriteLine($"HDestructor:\t{GetHashCode()}");
        }
        public override string ToString()
        {
            return (base.ToString() + $":".PadRight(22) { LastName.PadRight(12)} {FirstName.PadRight(12)} {Age.ToString().PadRight(5)}" y/o);
        }
    }
}
