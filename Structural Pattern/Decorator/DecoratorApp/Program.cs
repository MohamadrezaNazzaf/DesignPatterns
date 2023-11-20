using DecoratorApp.Example.EmailExample;
using DecoratorApp.Example.SmsExample;
using DecoratorApp.UML;

namespace DecoratorApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" ******** UML ******** \n");

        ConcreteComponent concreteComponent = new ConcreteComponent();
        //concreteComponent.operation();

        ConcreteDecorator concreteDecorator = new ConcreteDecorator(concreteComponent);
        concreteDecorator.operation();

        Console.WriteLine("\n ******** Email Example ******** \n");

        SendEmail sendEmail = new SendEmail();
        DecoratorSendEmail decoratorSendEmail = new DecoratorSendEmail(sendEmail);

        decoratorSendEmail.Send();

        Console.WriteLine("\n ******** SMS Example ********\n");

        ISmsSender smsSender = new SmsSender();
        ISmsSender smsSenderDecorator = new SmsSenderWithLogging(smsSender);


        smsSenderDecorator.Send("Gn babe.");
        Console.ReadKey();
    }
}