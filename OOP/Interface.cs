namespace OOP
{
    public interface IFly
    {
        public void Fly();
    }

    //实现接口，可实现多个接口
    public class Plane : IFly
    {
        public void Fly()
        {
        }
    }

    public class Bird : IFly
    {
        public void Fly()
        {
        }
    }


    //接口继承
    public interface Interface1
    {
        public void Fly();
    }
    public interface Interface2
    {
        public void Run();
    }

    class AllInterfaces : Interface1, Interface2
    {
        public void Fly()
        {
            throw new System.NotImplementedException();
        }

        public void Run()
        {
            throw new System.NotImplementedException();
        }
    }
}
