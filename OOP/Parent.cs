using System;

namespace OOP
{
    class Parent
    {
        public Parent()
        {
            Console.WriteLine("这一行输出是父类的构造函数起的作用");
        }

        //public Parent(string lastName) { }
        public string LastName { get; set; }    //姓，Kevin Durant，Durant是姓氏，Kevin是名字

        //自动属性语法（带初始值）
        public string HomeAddress { get; set; } = "北京";

        public virtual void Work()
        {
            Console.WriteLine("父类的虚方法");
        }

        public void Sleep()
        {
            Console.WriteLine("父类的方法");
        }
    }
}
