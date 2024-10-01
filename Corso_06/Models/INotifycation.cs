using System;
namespace Corso_06.Models
{
    public interface INotifycation
    {
        event EventHandler NotificationReceived;
    }
}
