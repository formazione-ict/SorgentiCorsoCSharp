using System;
using System.Collections.Generic;
using Corso_13.Models;
using Corso_13.Provider;
using System.Linq;

namespace Corso_13
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var customers = new List<Customer>();
            customers = CustomerProvider.GetCustomers();

            #region IEquatable

            //Console.WriteLine("Elenco clienti");
            //foreach (var customer in customers)
            //    Console.WriteLine($"[{customer.No}] {customer.Name} - {customer.Address}, {customer.City}");

            //Console.WriteLine($"\nRICERCA\n");
            //var customerToSearch = new Customer();
            ////customerToSearch.No = "C0002123";
            //customerToSearch.Name = "RILLA";

            //if (customers.Contains(customerToSearch))
            //    //Console.WriteLine($"Cliente {customerToSearch.No} trovato in elenco");
            //    Console.WriteLine($"Cliente trovato in elenco con chiave di ricerca '{customerToSearch.Name}'");
            //else
            //    //Console.WriteLine($"Cliente {customerToSearch.No} non esiste in elenco");
            //    Console.WriteLine($"Nessuno cliente trovato con chiave di ricerca '{customerToSearch.Name}'");

            //if(customers[0] == customers[3])
            //{

            //}
            #endregion

            var firstCustomer = customers.SingleOrDefault(x => x.No == "C0001");
            var secondCustomer = customers.SingleOrDefault(x => x.No == "C0003");

            if (firstCustomer.LastUpdate.HasValue)
                Console.WriteLine($"Il cliente {firstCustomer.Name} è stato aggiornato il {firstCustomer.LastUpdate.Value:dd MMMM yyyy}");
            else
                Console.WriteLine($"Il cliente {firstCustomer.Name} è nuovo");

            if (secondCustomer.LastUpdate.HasValue)
                Console.WriteLine($"Il cliente {secondCustomer.Name} è stato aggiornato il {secondCustomer.LastUpdate.Value}");
            else
                Console.WriteLine($"Il cliente {secondCustomer.Name} è nuovo");
        }
    }
}
