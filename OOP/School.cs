using System;

namespace OOP
{
    class School
    {
        ////创建类实例时，将会调用其构造函数（无返回值），构造函数可有多个，但只能调用一次，若无构造函数则系统默认创建一个无参构造函数
        ////根据实例化的参数确定，调用某个构造函数
        ////类实例化之后，每个字段就被初始化了。值类型默认值是0，引用类型是null
        public School() { Console.WriteLine("Hello"); }
        public School(string name) { Console.WriteLine(name); }
        public string Name { get; set; }
        public string Address { get; set; }

    }
}
