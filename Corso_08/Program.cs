using System;
using Corso_08.Models;

namespace Corso_08
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Customer newCustomer = new Customer();
            newCustomer.ErrorRecevied += NewCustomer_ErrorRecevied;

            Console.Write("Nome cliente: ");
            newCustomer.Name = Console.ReadLine();
            Console.Write("ID cliente: ");
            newCustomer.ID = Console.ReadLine();;

            newCustomer.Country = Customer.DefaultCountry;
            Console.WriteLine($"Cliente 1: [{newCustomer.ID}] {newCustomer.Name} ({newCustomer.Country})");

            newCustomer = new Customer();
            newCustomer.ErrorRecevied += NewCustomer_ErrorRecevied;
            newCustomer.Name = "pippo";
            newCustomer.ID = "123";
            newCustomer.Country = "uk";
            Console.WriteLine($"Cliente 2: [{newCustomer.ID}] {newCustomer.Name} ({newCustomer.Country})");

            newCustomer = new Customer();
            newCustomer.ErrorRecevied += NewCustomer_ErrorRecevied;
            newCustomer.Name = "pluto";
            newCustomer.ID = "34XX";
            newCustomer.Country = "fr";



            Console.WriteLine($"Cliente 3: [{newCustomer.ID}] {newCustomer.Name} ({newCustomer.Country})");

            newCustomer = Customer.GenerateRandomCustomer();
            Console.WriteLine($"Cliente Random: [{newCustomer.ID}] {newCustomer.Name} ({newCustomer.Country})");
        }

        static void NewCustomer_ErrorRecevied(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Errore: {message}");
            Console.ResetColor();
        }

    }
}
