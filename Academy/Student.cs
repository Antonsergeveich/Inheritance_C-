using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Student:Human
    {
        public string Speciality {  get; set; }
        public string Group { get; set; }
        public double Rating { get; set; }
        public double Attendance {  get; set; }
        public Student
            (
            string lastName, string firstName, uint age,
            string speciality, string group, double rating, double attendance
            ):base(lastName, firstName, age)
        {
            Speciality = speciality;
            Group = group;
            Rating = rating;
            Attendance = attendance;
            Console.WriteLine($"SConstructor:\t{GetHashCode()}");
        }
        public Student(Human human, string speciality, string group, double rating, double attendance):base(human)
        {
            Speciality=speciality;
            Group = group;
            Rating = rating;
            Attendance = attendance;
            Console.WriteLine($"SConstructor:\t{GetHashCode()}");
        }

        public Student(Student other) : base(other) 
            //UpCast - приведение дочернего типа к базовому типу 
            //DownCast - преобразование от базового типа к дочернему
        {
            this.Speciality = other.Speciality;
            this.Group = other.Group;
            this.Rating = other.Rating;
            this.Attendance = other.Attendance;
            Console.WriteLine($"SCopyConstryctor:\t{GetHashCode()}");
        }

        ~Student() 
        {
            Console.WriteLine($"SDestructor:\t{GetHashCode()}");
        }
        public override string ToString()
        {
            return base.ToString()+$" {Speciality} {Group} {Rating} {Attendance}";
        }
    }
}
