using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;


namespace SendingLettersByMail.UsersClasses
{
    private class SendingEmail
    {
        private InfoEmailSending InfoEmailSending { get; set; }

        private SendingEmail(InfoEmailSending infoEmailSending)
        {
            InfoEmailSending = infoEmailSending
                ?? throw new ArgumentNullException(nameof(infoEmailSending));
        }

        public void Send()
        {

        }
    }
}
