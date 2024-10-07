//#define INHERITANCE_1
//#define INHERITANCE_2
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
            //  каждый класс описан в отдельном файле
            Human human = new Human("Vercetty", "Tommy", 30);
            Console.WriteLine(human);

            Student student = new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 95, 96);
            Console.WriteLine(student);

            Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 25);
            Console.WriteLine(teacher); 
#endif

#if INHERITANCE_2
            Human tommy = new Human("Vercetty", "Tommy", 30);
            Console.WriteLine(tommy);

            Student student_tommy = new Student(tommy, "Theft", "Vice", 95, 98);
            Console.WriteLine(student_tommy);

            Human ricardo = new Human("Diaz", "Ricardo", 50);
            Console.WriteLine(ricardo);

            Teacher teacher_ricardo = new Teacher(ricardo, "Weapons distibution", 20);
            Console.WriteLine(teacher_ricardo);

            Graduate graduate = new Graduate("Schereder", "Hank", 40, "Criminalistic", "OBN", 50, 40, "How to catch Hiesenberg");
            Console.WriteLine(graduate);

            Graduate graduate_tommy = new Graduate(student_tommy, "How to make money");
            Console.WriteLine(graduate_tommy); 
#endif
            Human[] group = new Human[]
                {
                    new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 95, 96),
                    new Teacher("White", "Walter", 50, "Chemistry", 25),
                    new Graduate("Schereder", "Hank", 40, "Criminalistic", "OBN", 50, 40, "How to catch Hiesenberg"),
                    new Student("Vercetty", "Tommy", 30, "Theft", "Vice", 95, 98),
                    new Teacher("Diaz", "Ricardo", 50, "Weapons distibution", 20)
                };
            for (int i = 0; i < group.Length; i++)
            {
                Console.WriteLine($"{group[i]};");
            }
        }
    }
}
