using System;
namespace Corso_06.Models
{
    public class Rectangle : Sprite, IEquatable<Rectangle>
    {
        public override void GetArea()
        {
            base.GetArea();

            var area = base.Height * base.Width;
            Console.WriteLine($"Rettangolo: {area}");
        }

        public bool Equals(Rectangle obj)
        {
            return ((base.Height == obj.Height) &&
                    (base.Width == obj.Width));
        }

        public Rectangle(int pHeight, int pWidth) : base(pHeight, pWidth)
        {

        }
    }

}
