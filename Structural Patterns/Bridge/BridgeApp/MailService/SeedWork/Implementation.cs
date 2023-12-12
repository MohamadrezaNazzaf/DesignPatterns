using System.Configuration;

namespace BridgeApp.MailService.SeedWork;

public static class Implementation
{
    public static IMailServiceImplementor GetImplementor()
    {
        var config = ConfigurationManager.AppSettings; // get data from App.config file.

        return config["EmailImplementor"] switch
        {
            "Gmail" => new GmailService(),
            "Yahoo" => new YahooService(),
            _ => new MyCompanyMailService()
        };
    }
}