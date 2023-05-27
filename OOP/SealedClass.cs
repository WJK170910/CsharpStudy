namespace OOP
{
    class Base
    {
        public virtual void Function() { }
    }
    class Derived : Base
    {
        public sealed override void Function() { }
    }

    class Test : Derived
    {
        //sealed表示密封，方法不能再被重写了
        //public sealed override void Function() { }
    }
}
