using System;
using Corso_05.Models;

namespace Corso_09
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Book myFirstBook = new Book();

            myFirstBook.author = "J. R. R. Tolkien";
            myFirstBook.title = "Il Silmarillion";
            myFirstBook.Price = 12.3M;

            Console.WriteLine($"{myFirstBook.title.ToUpper()} di {myFirstBook.author} a sole {myFirstBook.Price:C}");

            Book secondBook = myFirstBook;

            object generic = secondBook;

            secondBook.title = "My first thiller";

            Console.WriteLine($"{secondBook.title.ToUpper()} di {secondBook.author} a sole {secondBook.Price:C}");
            Console.WriteLine($"{myFirstBook.title.ToUpper()} di {myFirstBook.author} a sole {myFirstBook.Price:C}");


            Car tesla = new Car("Sandy");

            tesla.Model = "My Tesla";

            Console.WriteLine($"Model Tesla: {tesla.Model}");

            Car pippo = tesla;

            pippo.Model = "Pluto";
            Console.WriteLine($"Model Pluto: {pippo.Model.ToString()}");

            Console.WriteLine($"Model Tesla: {tesla.Model}");



        }
    }
}
