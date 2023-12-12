namespace DecoratorApp.Example.EmailExample;

public class DecoratorSendEmail : SendEmail
{
    private readonly SendEmail _sendEmail;

    public DecoratorSendEmail(SendEmail sendEmail)
    {
        _sendEmail = sendEmail;
    }

    public void Send()
    {
        _sendEmail.Send();
        SaveLog();
    }

    private void SaveLog()
    {
        Console.WriteLine("Log is save;");
    }
}