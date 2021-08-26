using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class OrderCollection
    {
        private string _toppingName;
        private string _sizeName;
        private double _orderTotal;
        private int _orderQuantity;
        private double _priceTopping;
        private double _priceSize;
        private int _pizzaQuantity;
        private double _pizzaTotal;
        public string toppingName
        {
            get { return _toppingName; }
            set { _toppingName = value; }
        }
        public string sizeName
        {
            set { _sizeName = value; }
            get { return _sizeName; }
        }
        public double orderTotal
        {
            set { _orderTotal = value; }
            get { return _orderTotal; }
        }
        public int orderQuantity
        {
            set { _orderQuantity = value; }
            get { return _orderQuantity; }
        }
        public double priceTopping
        {
            set { _priceTopping = value; }
            get { return _priceTopping; }
        }
        public double priceSize
        {
            set { _priceSize = value; }
            get { return _priceSize; }
        }
        public int pizzaQuantity
        {
            set { _pizzaQuantity = value; }
            get { return _pizzaQuantity; }
        }
        public double pizzaTotal
        {
            set { _pizzaTotal = value; }
            get { return _pizzaTotal; }
        }
        public OrderCollection(string tn, string sn, int oq, double ot, double pt, double ps, int pq, double pizzaTot)
        {
            this.toppingName = tn;
            this.sizeName = sn;
            this.orderTotal = ot;
            this.orderQuantity = oq;
            this.priceTopping = pt;
            this.priceSize = ps;
            this.pizzaQuantity = pq;
            this.pizzaTotal = pizzaTot;
        }
    }
}
