using System;
namespace Corso_05.Models
{
    public class GearChangeEventArgs : EventArgs
    {
        public GearChangeEventArgs()
        {
        }

        public string Message
        {
            get;
            set;
        }

        public GearChanges GearChange
        {
            get;
            set;
        }
    }
}
