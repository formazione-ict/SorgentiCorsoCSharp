using System;

namespace Corso_14
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string message = "ciao Mondo!";
            object obj = message;
            int age = 41;
            TextUtility textUtility = new TextUtility();
            string codeToValidate = "ABC123Z";

            try
            {

                //int age = 41;
                //Conversione non valida
                //age = (int)obj;

                Console.Write($"Validazione codice {codeToValidate}: ");
                textUtility.CheckCode(codeToValidate);
                Console.WriteLine("OK");

                Console.WriteLine("Fine del blocco try");
            }
            catch(IndexOutOfRangeException ore)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Errore: {ore.Message}");
                Console.ResetColor();
            }
            catch (InvalidCastException ice)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Errore: {ice.Message}");
                Console.ResetColor();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Errore: {e.Message}");
                Console.ResetColor();
            }
            finally
            {
                Console.WriteLine("\nBlocco di finally");
                Console.WriteLine($"età = {age}");
            }
        }
    }
}
