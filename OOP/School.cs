using System.Collections.Generic;

namespace OOP
{
    class School
    {
        ////创建类实例时，将会调用其构造函数（无返回值），构造函数可有多个，但只能调用一次，若无构造函数则系统默认创建一个无参构造函数
        ////根据实例化的参数确定，调用某个构造函数
        ////类实例化之后，每个字段就被初始化了。值类型默认值是0，引用类型是null
        //public School() { Console.WriteLine("Hello"); }

        ////当构造函数传入的参数和类成员重名时，this关键字指向对象本身引用
        //public School(string Name) { Console.WriteLine(Name + ":" + this.Name); }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Student> Students { get; set; }
    }
}
