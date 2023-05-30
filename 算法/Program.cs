using System;

namespace 算法
{
    class Program
    {
        delegate T[] Method<T>(T[] data, Func<T, T, bool> func);

        public static T[] SalaryOrder<T>(T[] data, Func<T, T, bool> func)
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int k = 0; k < data.Length - 1; k++)
                {
                    if (func(data[k], data[k + 1]))
                    {
                        var temp = data[k + 1];
                        data[k + 1] = data[k];
                        data[k] = temp;
                    }
                }
            }
            return data;
        }
        static void Main(string[] args)
        {
            #region 冒泡排序
            ////对于给定的n个记录，从第一个记录开始依次对相邻的两个记录进行比较，
            ////当前面的记录大于后面的记录时，交换这两个记录，进行一轮比较和换位后，n个记录中的最大记录将位于第n位；
            ////然后对前（n-1）个记录进行第二轮比较；重复该过程直到进行比较的记录只剩下一个为止.
            //int[] intArray = { 17, 2, 42, 6, 97, 10 };
            //for (int i = 0; i < intArray.Length - 1; i++)
            //{
            //    for (int k = 0; k < intArray.Length - 1; k++)
            //    {
            //        if (intArray[k] > intArray[k + 1])
            //        {
            //            int temp = intArray[k + 1];
            //            intArray[k + 1] = intArray[k];
            //            intArray[k] = temp;
            //        }
            //    }
            //}

            //Console.WriteLine(intArray[0]);
            #endregion

            #region 利用委托升级冒泡排序
            ////将要处理的data和处理的condition作为参数传递，实现逻辑时不关注条件是什么，降低耦合
            Employee[] employee = {
                new Employee { Name = "Adam",   Salary = 8000,  Id = 2  },
                new Employee { Name = "Jack",   Salary = 9000,  Id = 5  },
                new Employee { Name = "Kevin",  Salary = 3000,  Id = 3  },
                new Employee { Name = "James",  Salary = 3200,  Id = 1  }
            };

            Method<Employee> method = SalaryOrder;
            method(employee, Employee.CompareLogic);

            foreach (var item in employee) Console.WriteLine(item.Id + ":" + item.Name + ",Salary is " + item.Salary);

            Console.ReadKey();

            #endregion



        }
    }
}
