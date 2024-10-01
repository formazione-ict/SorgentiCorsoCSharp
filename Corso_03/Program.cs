using System;

namespace Corso_03
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string myFirstName = "Dario";
            string myLastName = "Concilio";
            DateTime myBirthday = new DateTime(1977, 8, 3);
            float myHeight = 1.68123F;
            byte myAge = Convert.ToByte(DateTime.Now.Year - myBirthday.Year);
            decimal myBigValue = 1231324324234.234324M;

            string text1 = "Ciao! Mi chiamo " + myFirstName + " " + myLastName + ", tu come ti chiami?";

            string text2 = String.Format("Ciao! Mi chiamo {1} {0} , tu come ti chiami?", myFirstName, myLastName);

            string text3 = $"Ciao! Mi chiamo {myFirstName} {myLastName}, tu come ti chiami?";

            string text4 = String.Format("Sono nato il {0:dd MMMM} del {0:yyyy}", myBirthday);

            string text5 = $"Sono nato il {myBirthday:dd MMMM} del {myBirthday:yyyy}";

            string text6 = $"Sono alto {myHeight:N2} m";

            string text7 = $"Ho {myAge}";

            Console.WriteLine(text1);
            Console.WriteLine(text2);
            Console.WriteLine(text3);
            Console.WriteLine(text4);
            Console.WriteLine(text5);
            Console.WriteLine(text6);
            Console.WriteLine(text7);

            Console.WriteLine($"Valore grande {myBigValue:###.000}");
            Console.WriteLine($"Vallore grande {myBigValue:###.0}");
            Console.WriteLine($"Vallore grande {myBigValue:E}");
            Console.WriteLine($"Vallore grande {myBigValue:C2}");

            int index = text3.IndexOf("Mi");
            Console.WriteLine($"La posizione di \"Mi\" è {index}");
            Console.WriteLine($"Risultato: {text3.Substring(index, 2)}");

            Console.WriteLine($"{text3.Replace("Mi", "Ti")}");

        }
    }
}
