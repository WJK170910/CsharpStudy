using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            //School school = new School("Adam");
            school.Name = "第三中学";
            Console.WriteLine("The school's Name is " + school.Name);
            Console.ReadKey();
        }
    }
}
