using System;
namespace Corso_08.Models
{
    public class StaticEventArgs : EventArgs
    {
        public StaticEventArgs()
        {
        }

        public string Message
        {
            get;
            set;
        }
    }
}
