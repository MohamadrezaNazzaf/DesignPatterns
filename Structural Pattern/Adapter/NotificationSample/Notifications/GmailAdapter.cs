namespace NotificationSample.Notifications;

public class GmailAdapter : ISendMessage
{
    GmailServiceGoogle gmailService = new GmailServiceGoogle();
    public void Send(string Text)
    {
        gmailService.SendMail(Text);
    }

    private class GmailServiceGoogle
    {
        public void SendMail(string text)
        {
        }
    }
}
