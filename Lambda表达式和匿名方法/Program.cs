using System;

namespace Lambda表达式和匿名方法
{
    class Program
    {
        static void Main(string[] args)
        {
            ////匿名方法

            Func<int, int, int> func = delegate (int a, int b) { Console.WriteLine("这是一个匿名方法:" + a); return a; };


            ////Lambda表达式


            func = (a, b) => { Console.WriteLine(a + b); return a = a + b; };
            func += (a, b) => a + b;
            func(1, 2);
            Console.Read();
        }
    }
}
