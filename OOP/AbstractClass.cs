namespace OOP
{
    ////抽象类是一个"不完整的模板"，不能实例化，包含的抽象方法没有方法体，交由子类去实现
    abstract class AbstractClass
    {
        public abstract void Print();
    }

    class implement : AbstractClass
    {
        public override void Print()
        {
        }

    }
}
