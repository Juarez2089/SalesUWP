using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Email;

namespace SalesSystem.Models
{
    public class UserModel : PropertyChangedNotification
    {
        public string Email
        {
            get { return GetValue(() => Email); }
            set 
            {
                    SetValue(() => Email, value);
                    EmailMessages = "";
                    Messages = "";
            }
        }
        public string Password
        {
            get { return GetValue(() => Password); }
            set
            {
                SetValue(() => Password, value);
                PasswordMessages = "";
                Messages= "";
            }
        }

        public string Messages
        {
            get { return GetValue(() => Messages); }
            set { SetValue(() => Messages, value); }
        }
        public string EmailMessages
        {
            get { return GetValue(() => EmailMessages); }
            set { SetValue(() => EmailMessages, value); }
        }
        public string PasswordMessages
        {
            get { return GetValue(() => PasswordMessages); }
            set { SetValue(() => PasswordMessages, value); }
        }
    }
}
