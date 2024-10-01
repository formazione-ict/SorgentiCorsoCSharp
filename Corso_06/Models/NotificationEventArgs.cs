using System;
namespace Corso_06.Models
{
    public class NotificationEventArgs : EventArgs
    {
        public NotificationEventArgs(string pMessage) {
            this.Message = pMessage;
        }

        public string Message
        {
            get;
            set;
        }
    }
}
