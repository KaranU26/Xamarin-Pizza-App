using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
     public class Toppings
    {
        private string _name;
        private double _price;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double price
        {
            set { _price = value; }
            get { return _price; }
        }

        public Toppings(string n, double p)
        {
            this.name = n;
            this.price = p;
        }
    }
}
