using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Teacher:Human
    {
        public string Speciality { get; set; }
        public uint Experience { get; set; }
        public Teacher
            (
                string lastName, string firstName, uint age,
                string speciality, uint experience
            ):base(lastName, firstName, age)
        { 
            
            Speciality = speciality;
            Experience = experience;
            Console.WriteLine($"TConstr:\t{GetHashCode()}");
        }
        public Teacher(Human human, string speciality, uint experience): base(human)
        {
            Speciality = speciality;
            Experience = experience;
            Console.WriteLine($"TConstr:\t{GetHashCode()}");
        }
        ~Teacher() 
        {
            Console.WriteLine($"TDestr: \t{GetHashCode()}");
        }


        //  явл. виртуальной - может быть переопределена в дочернем классе,
        //  и неявно каждый раз вызывается в main в Console.WriteLine(имя_объекта)
        public override string ToString() 
        {
            return base.ToString() + $" {Speciality}, {Experience}";
        }
    }
}
