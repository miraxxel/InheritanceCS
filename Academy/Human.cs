using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Human
    {
        static readonly int

        // исп. авто св-ва
        public string LastName {get; set;}
        public string FirstName {get; set;}
        public uint Age {get; set;}

        public Human (string lastName, string firstName, uint age)
        {
            LastName = lastName;
            FirstName = firstName;
            Age = age;
            Console.WriteLine($"HConstr:\t{GetHashCode()}");
        }
        public Human(Human other)
        {
            this.LastName = other.LastName;
            this.FirstName = other.FirstName;
            this.Age = other.Age;
            Console.WriteLine($"HCopyConstr:\t{GetHashCode()}");
        }
        ~Human () // необяз. пропис. явно
        {
            Console.WriteLine($"HDestr: \t{GetHashCode()}");
        }

        public override string ToString()
        {
            //  base.ToString() вызывает реализацию метода ToString() из базового класса Object.
            //  по умолчанию этот метод возвращает строку, содержащую полное имя типа объекта (например, "Academy.Human")
            return (base.ToString() + ":").PadRight(22) + $"{LastName.PadRight(12)} {FirstName.PadRight(12)} {Age.ToString().PadRight(5)} y/o";
        }
    }
}
