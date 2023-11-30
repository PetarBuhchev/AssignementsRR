using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Book
    {
        public string title;
        private string author = "Victor Hugo";
        private decimal price = 1;
        private int quantity;

        public string Author { get { return this.author; } }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value > 1 && value < 1000)
                {
                    this.price = value;
                } 
            } 
        }
        public int Quantity
        {
            get { return this.quantity; }
            set
            {
                if (value >= 0)
                {
                    this.quantity = value;
                }
            }
        }

        public static double TotalSum (decimal price, int quantity)
        {
            double total = 0;
            total += (double)price * quantity;
            return total;
        }
    }
}
