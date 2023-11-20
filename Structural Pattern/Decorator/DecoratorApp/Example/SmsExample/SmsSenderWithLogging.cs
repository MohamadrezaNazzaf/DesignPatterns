namespace DecoratorApp.Example.SmsExample;

// ConcreteDecorator
public class SmsSenderWithLogging : SmsSenderDecorator
{
    public SmsSenderWithLogging(ISmsSender smsSender) : base(smsSender)
    {
    }

    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"Recording log: {message}");
    }
}