using System;
namespace PrivateBaseClass
{
    public class Employee
    {
        public Employee()
        {
        }

        string name = "FirstName, LastName";
        double salary = 100.0;

        public string GetName()
        {
            return name;
        }

        double Salary
        {
            get { return salary; }
        }
    }
}
