using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 算法
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public static bool CompareLogic(Employee employee1, Employee employee2)
        {
            return employee1.Id > employee2.Id;
        }
    }
}
