using System;

namespace Corso_01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int MAJOR_AGE = 18;
            string firstName;
            string lastName;
            int age;
            DateTime birthDay;
            int offsetMajorAge;

            Console.WriteLine("Inserimento informazioni:");

            Console.Write("Nome: ");
            firstName = Console.ReadLine();

            Console.Write("Cognome: ");
            lastName = Console.ReadLine();

            Console.Write("Quando sei nato (gg/mm/aaaa)? ");
            birthDay = Convert.ToDateTime(Console.ReadLine());

            //Verifico che l'utente sia maggiorenne
            age = DateTime.Now.Year - birthDay.Year;
            if (age >= MAJOR_AGE) 
            {
                Console.WriteLine("Complimenti, puoi fare la patente!");
            } 
            else 
            {
                offsetMajorAge = MAJOR_AGE - age;
                Console.WriteLine($"Devi aspettare ancora {offsetMajorAge} anni per fare la patente. Forza e coraggio!");
            }
        }
    }
}
