using System;

namespace Function
{
    class Program
    {
        ////名为Main，无返回值，传入参数(形参)是args的方法
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Add(1, 2);
            program.Function(1, 2, 2, 2, 2, 2, 3);

            ////实参,若方法是静态的，则可以直接调用
            //Add(1, 2);              
            Console.WriteLine("Hello World!");
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        ////方法的重载（overload），方法名相同，参数列表不同（个数，类型）
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        ////方法中的参数数组必须放在参数的最后，会根据调用时传入的参自动拼装
        public int Function(int a, params int[] intArray)
        {
            return a + intArray[0];
        }
    }
}
