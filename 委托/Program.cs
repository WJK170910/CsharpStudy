using System;

namespace 委托
{
    class Program
    {
        ////委托是一种引用类型，表示对具有特定签名的方法的引用,没有方法体，签名：参数列表、返回值
        ////本质是类，通过反射查看
        ////应用场景：多线程
        delegate double Add(int x, int y);
        delegate int Method(int x);
        delegate string GetString();
        public double AddMethod(int x, int y)
        {
            return x + y;
        }
        public void ActionMethod(int x, int y)
        {
        }
        public void TestActionDelegateMethod()
        {
        }
        public int TestFuncDelegateMethod()
        {
            return 0;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            ////给委托赋值时使用方法名即可，带()意为调用方法
            ////可以指向静态方法或实例方法
            Add add = new Add(program.AddMethod);
            Console.WriteLine(add(1, 2));

            //int x = 123;
            //GetString getString = new GetString(x.ToString);

            ////委托数组及作为参数使用
            MathMethod mathMethod = new MathMethod();

            Method[] method = { mathMethod.Add, mathMethod.Multiply };

            foreach (var item in method) Console.WriteLine(item(3));


            ////Action委托
            ////无返回值，可以有任意个参数
            Action action1 = program.TestActionDelegateMethod;
            //action1.Invoke();
            Action<int, int> action = program.ActionMethod;


            ////Func委托
            ////有返回值，可以有任意个参数
            ////返回值位于泛型中最后一位,下面的例子中返回类型为double，有两个int的参数
            Func<int> func1 = program.TestFuncDelegateMethod;
            Func<int, int, double> func = program.AddMethod;
            Console.WriteLine(func(234, 234));


            #region 多播委托

            ////只会得到最后一个方法的结果
            //Method method1 = mathMethod.Add;
            //method1 += mathMethod.Multiply;
            //method1 -= mathMethod.Add;
            //Console.WriteLine(method1(10));

            #endregion

            Console.ReadKey();
        }
    }
}