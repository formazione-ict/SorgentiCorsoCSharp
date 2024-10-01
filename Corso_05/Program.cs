using System;
using Corso_05.Models;

namespace Corso_05
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Car ferrari = new Car("F40", ConsoleColor.Red, 3000);
            Car volkswagen = new Car("Golf", ConsoleColor.Black, 1800);

            ferrari.GearChanged += Ferrari_GearChanged;

            ferrari.Start();
            volkswagen.Start();

            ferrari.GearUp();
            ferrari.IncreaseSpeed(10);
            ferrari.GearUp();
            ferrari.IncreaseSpeed(30);
            ferrari.GearDown();

            ferrari.GetInfo();
            volkswagen.GetInfo();

        }

        /*
        static void Ferrari_GearChanged(object sender, GearChangeEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Evento {DateTime.Now.ToLongTimeString()}: {e.GearChange.ToString()}");
            Console.ResetColor();
        }
        */


        static void Ferrari_GearChanged(GearChangeEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Evento {DateTime.Now.ToLongTimeString()}: {e.GearChange.ToString()}");
            Console.ResetColor();
        }


    }
}
