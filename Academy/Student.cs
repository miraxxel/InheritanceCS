using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    // что класс наследуется, указываем через :'класс от которого наследуем'
    internal class Student:Human
    {
        public string Speciality { get; set; }
        public string Group { get; set; }
        public double Rating { get; set; }
        public double Attendance { get; set; }
        
        // кроме своих параметров, конструктор дочернего класса также должен принять параметры родительского
        public Student
            (
                string lastName, string firstName, uint age,
                string speciality, string group, double rating, double attendance
            // делегирование в пределах нашего класса выполняется при помощи this, а если хотим в базовый, то пишем base
            ):base(lastName, firstName, age)
        {
            Speciality = speciality;
            Group = group;
            Rating = rating;
            Attendance = attendance;
            Console.WriteLine($"SConstr:\t{GetHashCode()}");
        }
        public Student(Human human, string speciality, string group, double rating, double attendance):base(human)
        {
            Speciality = speciality;
            Group = group;
            Rating = rating;
            Attendance = attendance;
            Console.WriteLine($"SConstr:\t{GetHashCode()}");
        }
        public Student(Student other): base(other)  // UpCast - обобщение (приведение дочернего типа к базовому(общему) типу)
        {
            this.Speciality = other.Speciality;
            this.Group = other.Group;
            this.Rating = other.Rating;
            this.Attendance = other.Attendance;
            Console.WriteLine($"SCopyConstr:\t{GetHashCode()}");
        }
        ~Student () 
        {
            Console.WriteLine($"SDestr: \t{GetHashCode()}");
        }
        public override string ToString()
        {
            return base.ToString() + $" {Speciality}, {Group}, {Rating}, {Attendance}";
        }
    }
}
