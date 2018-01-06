using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    //Notification class, a higher-level class, has a dependency on both the Email class and the SMS class, 
    //which are lower-level classes.In other words, Notification is depending on the concrete implementation of both Email and SMS


    public class Email
    {
        public string ToAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public void SendEmail()
        {
            //Send email
        }
    }

    public class SMS
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendSMS()
        {
            //Send sms
        }
    }

    public class Notification
    {
        private iEmail _email;
        private iSMS _sms;
        public Notification(Email em, SMS sm)
        {
            _email = new Email();
            _sms = new SMS();
        }

        public void Send()
        {
            _email.SendEmail();
            _sms.SendSMS();
        }
    }
}
