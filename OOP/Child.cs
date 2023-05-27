using System;

namespace OOP
{
    class Child : Parent
    {
        //public Child() : base() { }                           代表调用父类构造函数，但:base()可以省略
        //public Child(string lastName) : base(lastName) { }    代表将子类构造函数的参数传给父类构造函数    
        //public Child(string firstName, string lastName)
        //{
        ////base用来访问父类的成员
        //base.LastName = lastName;
        //this.LastName = lastName;
        //this.FirstName = firstName;
        //Console.WriteLine("这一行输出是子类的构造函数起的作用");
        //}
        public string FirstName { get; set; }       //名字
        //public readonly int Age = 20;             //只读字段，只能在定义或构造函数中赋值
        public void Action()
        {
            Console.WriteLine("My name is " + LastName + FirstName);
        }

        public override void Work()
        {
            //base.work();      //调用父类方法
            Console.WriteLine("子类重写的方法");
        }

        public new void Sleep()
        {
            Console.WriteLine("子类的方法");
        }
    }
}
