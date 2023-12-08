using SampleFactoryMethod.Sms.Kavenegar;
using SampleFactoryMethod.Sms.Twilio;

namespace SampleFactoryMethod.Sms.FactoryMethod
{
    public interface ICreator
    {
        ISmsManager FacatoryMethod(string implementorName);
    }

    public class Creator : ICreator
    {
        public ISmsManager FacatoryMethod(string implementorName)
        {

            return implementorName switch
            {
                nameof(TwilioSmsManager) => new TwilioSmsManager(),
                nameof(KavenegarSmsManager) => new KavenegarSmsManager()
            };
        }
    }
}
