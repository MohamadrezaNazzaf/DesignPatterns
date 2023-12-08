using SampleFactoryMethod.Sms;
using SampleFactoryMethod.Sms.FactoryMethod;
using SampleFactoryMethod.Sms.Kavenegar;

namespace SampleFactoryMethod;

class Program
{
    static void Main(string[] args)
    {
        ISmsManager sms;
        ICreator creator = new Creator();
        sms = creator.FacatoryMethod(nameof(KavenegarSmsManager));
        sms.Send(new SmsDto
        {
            Message = "test",
            Reciver = "0912000000",
        });
    }
}