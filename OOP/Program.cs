using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 类的实例化和构造函数的使用
            ////School school;                声明对象
            ////school = new School();         实例化对象


            ////School school = new School();
            //School school = new School("Adam");
            //school.Name = "第三中学";
            //Console.WriteLine("The school's Name is " + school.Name);

            #endregion

            #region 引用类型赋值问题

            ////类作为引用类型，把一个类赋值给另一个类的时，实际是把栈区的内存地址赋值了，当修改类的实际数据时，两个类相同的内存地址指向同一个堆区的数据
            ////故修改school2的值，school1的值也发生改变
            ////结构体作为值类型就不存在这种情况
            //School school1 = new School { Name = "中学", Address = "北京" };
            //School school2 = school1;
            //school2.Address = "上海";
            //Console.WriteLine(school1.Address);

            #endregion

            #region 浅拷贝、深拷贝
            ////浅拷贝复制对象的引用，原始对象和副本对象共享内存地址。
            ////深拷贝是将原始对象的所有内容复制到新的对象中，包括所有嵌套的对象和指向其他对象的引用。这意味着原始对象和副本对象不共享任何内存地址

            ////浅拷贝
            //School school1 = new School { Name = "第三中学", Address = "义乌市" };
            //School school2 = school1;

            //school2.Name = "第一中学";
            //Console.WriteLine(school1.Name);

            ////深拷贝
            //School school3 = new School { Name = "第三中学", Address = "义乌市" };
            //School school4 = new School { Name = school3.Name, Address = school3.Address };

            //school4.Name = "第一中学";
            //Console.WriteLine(school3.Name);

            #endregion

            #region 继承
            ////子类（派生类）只有一个父类（基类）
            ////子类实例化的时候会先调用父类的构造函数，在调用自己的构造函数
            ////子类某个属性改变值不影响父类，因为两个实例不是同一个内存地址

            //Parent parent = new Parent();
            ////Child child = new Child { HomeAddress = "北京", LastName = "", FirstName = "Adam" };
            //Child child = new Child("Adam", "");
            //child.Action();

            //child.HomeAddress = "沈阳";
            //Console.WriteLine(parent.HomeAddress);
            //Console.WriteLine(child.HomeAddress);
            #endregion

            #region 虚方法
            //Child child = new Child();
            //child.Work();
            #endregion

            #region 里氏转换
            ////变量声明为父类类型，用子类类型去实例化，无法调用子类的方法
            ////但因为虚方法有可能被子类重写，故可以调子类重写的方法，若没重写，则调用父类虚方法
            //Parent parent;
            //parent = new Child();
            //parent.Work();
            #endregion

            #region 隐藏方法
            ////子类的方法将父类中同名方法覆盖
            ////父类声明，以子类实例化时，调用父类的方法
            //Child child = new Child();
            //child.Sleep();

            //Parent parent = new Child();
            //parent.Sleep();

            #endregion

            #region 多态
            ////多态是同一个行为具有多个不同表现形式或形态的能力

            //IFly fly;
            //fly = new Plane();
            //fly = new Bird();

            #endregion

            #region 集合类List

            //ListClass listClass = new ListClass();
            //listClass.ListFunction();

            #endregion


            #region 泛型

            //MathFunction<double> mathFunction = new MathFunction<double>(22.1,23.7);
            //mathFunction.Add();

            #endregion

            #region 泛型方法

            //Program program = new Program();
            //program.GetResult<int>(10, 200);

            #endregion

            #region 手写一个List，实现增删功能

            //MyList myList = new MyList(1, 2, 3, 4, 5);
            //myList.Remove(5);
            //myList.Add(4);
            #endregion

            Console.ReadKey();
        }
        public T GetResult<T>(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            var result = (T)(num1 + num2);
            Console.WriteLine(result);
            return result;
        }


    }
}
