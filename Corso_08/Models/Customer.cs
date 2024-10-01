using System;
namespace Corso_08.Models
{
    public class Customer
    {
        string id;
        string name;
        string country;

        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                var intID = -1;
                if (Int32.TryParse(value, out intID))
                    id = value;
                else
                {
                    id = intID.ToString();
                    ErrorRecevied?.Invoke($"ID non valido per '{Name}'");
                }
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value.ToUpper();
            }
        }

        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value.ToUpper();
            }
        }

        public Customer()
        {
        }

        public Customer(string name, string id)
        {
            Name = name;
            ID = id;
        }

        public Customer(string pName, string pID, string pCountry)
        {
            Name = pName;
            ID = pID;
            Country = pCountry;
        }

        public delegate void ErrorEventHandler(string message);
        public event ErrorEventHandler ErrorRecevied;

        public static string DefaultCountry = "IT";

        public static Customer GenerateRandomCustomer()
        {
            var randomCustomer = new Customer();

            randomCustomer.ID = new Random(DateTime.Now.Second).ToString();
            randomCustomer.Name = $"Nome generico {randomCustomer.ID}";
            randomCustomer.Country = DefaultCountry;

            return randomCustomer;
        }

    }
}
