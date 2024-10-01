using System;
using System.Collections.Generic;
using System.Drawing;
using Corso_06.Models;

namespace Corso_06
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Sprite rect, circ, tria;

            rect = new Models.Rectangle(100, 30);
            circ = new Circle("Pippo", 200, 200);
            tria = new Triangle(400, 400);

             

            rect.GetArea();
            circ.GetArea();
            tria.GetArea();

            rect = new Sprite((Circle)circ);

            Size size = new Size(300, 100);
            Point point = new Point(5, 6);

            tria = new Sprite(size, point);

            Models.Rectangle first = new Models.Rectangle(100, 200);
            Models.Rectangle second = new Models.Rectangle(300, 200);

            if (first.Equals(second))
            {

            }


            Console.WriteLine("Premi un tasto per uscire");
            Console.ReadKey();
        }
    }
}
