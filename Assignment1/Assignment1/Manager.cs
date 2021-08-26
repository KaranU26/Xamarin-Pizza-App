using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Assignment1
{
    public class Manager
    {
        public List<Toppings> toppings = new List<Toppings>();
        public List<Size> sizes = new List<Size>();
        public ObservableCollection<OrderCollection> order = new ObservableCollection<OrderCollection>();
        public ObservableCollection<PlacedOrders> placeOrder = new ObservableCollection<PlacedOrders>();
        public int quantity;
        public int currentQuantity;
        public double totalPrice;
        public double toppingPrice;
        public double sizePrice;
        public string nameTopping;
        public string nameSize;
        public double pizzaTot;
        public double placedOrderTotal;
        public Manager()
        {
            toppings.Add(new Toppings("Vegetables", 3.34));
            toppings.Add(new Toppings("Meat Balls", 5.33));
            toppings.Add(new Toppings("Pepperoni", 2.25));
            toppings.Add(new Toppings("Mushrooms", 1.50));

            sizes.Add(new Size("Large", 7.25));
            sizes.Add(new Size("Medium", 6.50));
            sizes.Add(new Size("Small", 5.25));
            sizes.Add(new Size("Party", 10.50));

            quantity = 0;
            currentQuantity = 0;
            totalPrice = 0.0;
            toppingPrice = 0.0;
            pizzaTot = 0.0;
            placedOrderTotal = 0.0;
        }

        public void addOrder (OrderCollection ord)
        {
            order.Add(ord);
        }
        public void deleteOrder(OrderCollection ord)
        {
            order.Remove(ord);
        }
        public void addFinalOrder(PlacedOrders ord)
        {
            placeOrder.Add(ord);
        }
    }
}
