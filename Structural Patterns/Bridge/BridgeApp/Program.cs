using BridgeApp.MailService;
using BridgeApp.MailService.SeedWork;

//RefinedAbstraction abstraction = new RefinedAbstraction();
//abstraction.Function();

//This is Client

MailServiceAbstraction mailServiceAbstraction = new RefinedMailService();

mailServiceAbstraction.Send(new EmailInformationDto
{
    Reciver = "Elia Mohtashami",
    Title = "Invite",
    Message = "Please Come To My Party :)"
});