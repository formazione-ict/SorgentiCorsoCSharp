using System;

namespace PrivateTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            PrivateBaseClass.Employee e = new PrivateBaseClass.Employee();

            string n = e.GetName();
            double s = e.Salary;

            string testN = e.name;
        }
    }
}
