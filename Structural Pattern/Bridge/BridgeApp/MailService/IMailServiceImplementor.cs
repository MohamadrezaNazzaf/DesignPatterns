namespace BridgeApp.MailService;

public interface IMailServiceImplementor
{
    void SendEmail(string reciver, string title, string message);
}

class GmailService : IMailServiceImplementor
{
    public void SendEmail(string reciver, string title, string message)
    {
        Console.WriteLine($"Email --{title}-- Sended to --{reciver}--  With   **{nameof(GmailService)}**");
    }
}

class YahooService : IMailServiceImplementor
{
    public void SendEmail(string reciver, string title, string message)
    {
        Console.WriteLine($"Email --{title}-- Sended to --{reciver}--  With   **{nameof(YahooService)}**");
    }
}

public class MyCompanyMailService : IMailServiceImplementor
{
    public void SendEmail(string reciver, string title, string message)
    {
        Console.WriteLine($"Email --{title}-- Sended to --{reciver}-- With    **{nameof(MyCompanyMailService)}**");
    }
}