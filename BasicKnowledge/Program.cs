using System;
using System.Collections.Generic;

namespace BasicKnowledgem
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Write不换行、WriteLine会换行

            //Console.Write("Hello World!");
            //Console.WriteLine("Hello World!");
            #endregion

            #region 整型拼接的特殊用法

            //int a = 1;
            //int b = 2;
            //Console.WriteLine("" + a + b);

            #endregion

            #region 自增自减运算符
            ////a++   先赋值再增加          a--   先赋值再减少
            ////++a   先增加再赋值          --a   先减少再赋值
            //int a = 1;
            //Console.WriteLine(a++);     //1
            //Console.WriteLine(a);       //2


            //int b = 1;
            //Console.WriteLine(++b);     //2
            //Console.WriteLine(b);       //2
            #endregion

            #region 内存
            ////堆内存：空间大，读取慢
            ////栈内存：空间小，读取快
            ////静态存储区

            ////CLR（common language runtime）的GC（garba collector）是内存管理机制
            //声明变量会在内存中开辟一块空间并计数这块空间的引用，若计数为零，.net会自动处理，实现垃圾回收

            #endregion

            #region 数据类型
            ////值类型：整型、浮点型、bool、char、枚举、结构体
            ////直接把数据存储在栈内存中（stack）

            ////引用类型：string、数组、类
            ////需要两段内存：实际数据在堆内存中（heap），对于实际数据的引用（内存地址）在栈内存中，指向数据在堆中的位置

            #endregion

            #region 分支结构
            //int a = 1;
            //if (a != 2)
            //{
            //    Console.WriteLine("a != 2");
            //};

            ////switch语句中的default可有可无
            ////若不同case存在相同结果可按如下写法
            //switch (a)
            //{
            //    case 1:
            //    case 2:
            //        Console.WriteLine("a < 2");
            //        break;
            //};
            #endregion

            #region 循环结构
            ////break：跳出最近的一个循环
            ////continue：跳出当前次的循环，继续下一次的循环

            ////局部变量在作用域内使用完会自动销毁
            //int a = 1;
            //while (a == 1)
            //{
            //    List<int> list = new List<int> { 2, 5, 7 };
            //    int testValue = 5;
            //    if (testValue == 6)
            //    {
            //        Console.WriteLine(a);
            //    }
            //};

            //do
            //{
            //    Console.WriteLine(a);
            //} while (a == 1);

            ////表达式中一三号位可空（在外部声明），二号位若为空，则默认为true
            //for (; ; ) { };
            #endregion

            #region 类型转换
            //byte a = 5;
            //int b = 2000011;
            //a = (byte)b;    //显式转换（强转，可能丢失部分数据）
            //b = a;          //隐式转换（自动）

            ////装箱：值类型        -->     引用类型
            ////拆箱：引用类型      -->     值类型
            #endregion

            #region 数组
            ////声明
            //int[] intArray2;

            ////实例化、初始化
            //intArray2 = new int[] { 1, 23, 2 };

            //int[] intArray = new int[] { 1, 23, 2 };

            ////数组的索引/下标从0开始,索引也视作与首个元素的偏移量
            //intArray2[0];

            ////数组遍历  foreach

            ////声明并初始化
            //string a = "shaw";

            #endregion

            #region 匿名类型
            ////匿名类型声明和初始化需要同时进行，初始化后变量类型不可改变
            //var a = 1;
            #endregion

            #region 结构体赋值问题

            //Student student1 = new Student() { age = 1, name = "adam" };
            //Student student2 = new Student();

            //student2 = student1;
            //student2.age = 2;

            #endregion

            Console.ReadKey();

        }

        #region 枚举
        ////若无指定索引，按顺序从0开始
        ////若指定Worker索引为10，则依次0，10，11，12
        ////若指定Boss索引为10，则依次10，11，12，13

        //enum RoleType
        //{
        //    Boss,
        //    Worker,
        //    Manager,
        //    Cleaner
        //};
        #endregion

        #region 结构体
        //struct Student
        //{
        //    public int age;
        //    public string name;
        //    void Print()
        //    {
        //        Console.WriteLine("Hello");
        //    }
        //}
        #endregion

    }
}
