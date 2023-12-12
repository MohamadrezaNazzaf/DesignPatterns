namespace SampleFactoryMethod.Sms.Kavenegar
{
    public class KavenegarSmsManager : ISmsManager
    {
        public List<SmsDto> GetList()
        {
            List<SmsDto> sms = new List<SmsDto>();
            return sms;
        }

        public void Send(SmsDto sms)
        {
            Console.WriteLine("Send Sms  With KavenegarSmsManager..........");
            //send sms;

        }
    }
}
