using System;
namespace Corso_13.Models
{
    public class Customer : IEquatable<Customer>
    {
        public Customer()
        {
        }

        public string No { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public DateTime? LastUpdate { get; set; }
        public Nullable<DateTime> LastUpdate2 { get; set; }
        public decimal? LastInvoiceAmount { get; set; }

        public bool Equals(Customer pOtherCustomer)
        {
            if (pOtherCustomer == null)
                return false;

            //if (this.No == pOtherCustomer.No)
            //    return true;
            //else
                //return false;

            #region alternative compare
            if (this.Name.ToLower().Contains(pOtherCustomer.Name.ToLower()))
                return true;
            else
                return false;
            #endregion
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Customer customerObject = obj as Customer;
            if (customerObject == null)
                return false;
            else
                return Equals(customerObject);
        }

        public override int GetHashCode()
        {
            return No.GetHashCode();
            //return Name.GetHashCode();
        }

        public static bool operator ==(Customer pCustomer1, Customer pCustomer2)
        {
            if (((object)pCustomer1) == null || ((object)pCustomer2) == null)
                return Object.Equals(pCustomer1, pCustomer2);

            return pCustomer1.Equals(pCustomer2);
        }

        public static bool operator !=(Customer pCustomer1, Customer pCustomer2)
        {
            if (((object)pCustomer1) == null || ((object)pCustomer2) == null)
                return !Object.Equals(pCustomer1, pCustomer2);

            return !(pCustomer1.Equals(pCustomer2));
        }
    }
}
