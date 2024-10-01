using System;

namespace ProtectedTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ProtectedBaseClass.User u2 = new ProtectedBaseClass.User();


            SuperUser u = new SuperUser
            {
                Height = 10
            };

            var age1 = u.GetAge();

            Console.WriteLine($"Altezza: {u.Height}");
        }
    }
}
