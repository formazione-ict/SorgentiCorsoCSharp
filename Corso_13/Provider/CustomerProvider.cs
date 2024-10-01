using System;
using System.Collections.Generic;
using Corso_13.Models;

namespace Corso_13.Provider
{
    public class CustomerProvider
    {
        public static List<Customer> GetCustomers()
        {
            var customersOutput = new List<Customer>();

            customersOutput.Add(new Customer()
            {
                No = "C0001",
                Name = "Barilla S.p.a.",
                Address = "via del grano, 123",
                City = "Panetta",
                County = "MI",
                Country = "IT",
                LastUpdate = new DateTime(2018, 10, 23),
                LastInvoiceAmount = 13000
            });
            customersOutput.Add(new Customer()
            {
                No = "C0002",
                Name = "Ferrari S.p.a.",
                Address = "via delle macchine, 2",
                City = "Cilindri",
                County = "MB",
                Country = "IT",
                LastInvoiceAmount = 8500,
                LastUpdate = new DateTime(2017,3,12)
            });
            customersOutput.Add(new Customer()
            {
                No = "C0003",
                Name = "Matrix s.r.l.",
                Address = "via del digitale, 1010",
                City = "Macchine",
                County = "XX",
                Country = "XX"
            });
            customersOutput.Add(new Customer()
            {
                No = "C0004",
                Name = "Shield",
                Address = "Ignoto",
                City = "Ignota",
                County = "XX",
                Country = "XX"
            });
            customersOutput.Add(new Customer()
            {
                No = "C0005",
                Name = "Hydra",
                Address = "Ignoto",
                City = "Ignota",
                County = "XX",
                Country = "XX"
            });
            return customersOutput;
        }
    }
}
