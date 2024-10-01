using System;
namespace Corso_06.Models
{
    public class Triangle : Sprite
    {
        public override void GetArea()
        {
            base.GetArea();

            var area = base.Height * base.Width / 2;
            Console.WriteLine($"Triangolo: {area}");
        }

        public Triangle(int pHeight, int pWidth) : base(pHeight, pWidth)
        {

        }
    }
}
