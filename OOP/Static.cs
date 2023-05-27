namespace OOP
{
    //静态类，只包含静态成员,使用类名直接访问
    //不能实例化，不能被继承，本质是一个抽象的密封类
    //存储在静态存储区，不被堆区的对象享有
    //静态函数只能使用静态成员
    static class StaticClass
    {
        public const int Id = 1;            //const声明常量同时必须初始化
        public static int Age = 10;
    }
}
