namespace ProxyApp;

class Program
{
    static void Main(string[] args)
    {
        ISubject subject = new Proxy();

        subject.DoAction();

        Console.WriteLine("Hello World!");
    }

    public interface ISubject
    {
        void DoAction();
    }

    public class RealSubject : ISubject
    {
        public void DoAction()
        {
            Console.WriteLine("RealSubject.DoAction() is Run....");
        }
    }


    public class Proxy : ISubject
    {
        private RealSubject RealSubject;

        public void DoAction()
        {
            if (RealSubject == null)
            {
                RealSubject = new RealSubject();
            }
            RealSubject.DoAction();
        }
    }
}