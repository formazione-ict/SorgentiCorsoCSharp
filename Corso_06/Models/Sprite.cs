using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Security.Policy;
using static System.Net.Mime.MediaTypeNames;

namespace Corso_06.Models
{

    public class Sprite : INotifycation
    {

        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }

        #region public events

        public event EventHandler NotificationReceived;

        public void sendNotification(string pMessage)
        {
            OnNotificationReceived(new NotificationEventArgs(pMessage));
        }

        protected virtual void OnNotificationReceived(NotificationEventArgs e)
        {
            NotificationReceived?.Invoke(this, e);
        }

        #endregion

        /// <summary>
        /// Draw this instance.
        /// </summary>
        public virtual void GetArea()
        {
            Console.WriteLine("Calcolo dell'area");
        }

        public Sprite(int pHeight, int pWidth)
        {
            Height = pHeight;
            Width = pWidth;
            X = 0;
            Y = 0;
        }

        public Sprite(Circle pCircle)
        {
            X = pCircle.X;
            Y = pCircle.Y;
            Height = pCircle.Height;
            Width = pCircle.Width;
        }

        public Sprite(int pHeight, int pWidth, int pX, int pY)
        {
            Height = pHeight;
            Width = pWidth;
            X = pX;
            Y = pY;
        }

        public Sprite(Size pSize, Point pPoint)
        {
            Height = pSize.Height;
            Width = pSize.Width;
            X = pPoint.X;
            Y = pPoint.Y;
        }
    }

}
