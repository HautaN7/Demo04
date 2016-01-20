using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Firstname = "Kirsi";
            person.Lastname = "Kernel";
            person.Age = 31;
            person.Address = "Piippukatu 2";
            person.PhoneNumber = "645454513245";
            Console.WriteLine(person.ToString());

            Teacher teacher = new Teacher("Jussi", "Konsoli", "D456");
            teacher.Address = "Piippukatu 1";
            teacher.Age = 55;
            teacher.PhoneNumber = "4546872131";
            Console.WriteLine(teacher.ToString());

            Student student = new Student("Matti", "Kone", "K999");
            student.Age = 20;
            student.Address = "Piippukatu 3";
            student.PhoneNumber = "05048745414";
            Console.WriteLine(student.ToString());


            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}
