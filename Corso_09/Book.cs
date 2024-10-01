using System;
namespace Corso_09
{
    public struct Book
    {
        decimal price;
        public string title;
        public string author;

        public decimal Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
    }
}
