using BridgeApp.MailService.SeedWork;
using BridgeApp.UML.Implementors;

namespace BridgeApp.MailService;

public abstract class MailServiceAbstraction
{
    private readonly IMailServiceImplementor _implementor;

    protected MailServiceAbstraction()
    {
        _implementor = Implementation.GetImplementor();
    }

    public virtual void Send(EmailInformationDto email)
    {
        _implementor.SendEmail(email.Reciver, email.Title, email.Message);
    }
}

public class RefinedMailService : MailServiceAbstraction
{
}