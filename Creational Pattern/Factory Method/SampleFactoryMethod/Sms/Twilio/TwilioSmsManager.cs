namespace SampleFactoryMethod.Sms.Twilio
{
    public class TwilioSmsManager : ISmsManager
    {
        public List<SmsDto> GetList()
        {
            List<SmsDto> sms = new List<SmsDto>();
            return sms;
        }

        public void Send(SmsDto sms)
        {
            Console.WriteLine("Send Sms  With TwilioSmsManager..........");
            //send sms
        }
    }
}
