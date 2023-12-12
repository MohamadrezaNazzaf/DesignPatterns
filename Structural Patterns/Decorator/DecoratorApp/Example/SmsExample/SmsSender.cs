namespace DecoratorApp.Example.SmsExample;

//Concrete Component
public class SmsSender : ISmsSender
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending SMS: {message}");
    }
}