namespace DecoratorApp.Example.SmsExample;

// Decorator
public abstract class SmsSenderDecorator : ISmsSender
{
    private readonly ISmsSender _smsSender;

    public SmsSenderDecorator(ISmsSender smsSender)
    {
        _smsSender = smsSender;
    }

    public virtual void Send(string message)
    {
        _smsSender.Send(message);
    }
}