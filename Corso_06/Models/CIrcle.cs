using System;
namespace Corso_06.Models
{
    public class Circle : Sprite
    {
        public string Name
        {
            get;
            set;
        }

        public override void GetArea()
        {
            base.GetArea();

            var radius = base.Width / 2;

            var area = Math.PI * Math.Pow(radius, 2);

            //Console.WriteLine($"Cerchio: {area:F2}");
            base.sendNotification($"Cerchio: {area:F2}");
        }

        public Circle(string pName, int pHeight, int pWidth) : base(pHeight, pWidth)
        {
            Name = pName;
        }
    }
}
