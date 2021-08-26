using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class PlacedOrders
    {

        private double _orderTotal;
        private DateTime _currentTime;
        private int _Quant;

        public double orderTotal
        {
            set { _orderTotal = value; }
            get { return _orderTotal; }
        }
        public DateTime currentTime
        {
            set { _currentTime = value; }
            get { return _currentTime; }
        }
        public int quantity
        {
            set { _Quant = value; }
            get { return _Quant; }
        }

        public PlacedOrders(double ot, DateTime tm, int q)
        {

            this.orderTotal = ot;
            this.currentTime = tm;
            this.quantity = q;


        }
    }
}