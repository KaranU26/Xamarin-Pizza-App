using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class Size
    {
        private string _size;
        private double _price;

        public string size
        {
            get { return _size; }
            set { _size = value; }
        }
        public double price
        {
            set { _price = value; }
            get { return _price; }
        }

        public Size(string s, double p)
        {
            this.size = s;
            this.price = p;
        }
    }
}
