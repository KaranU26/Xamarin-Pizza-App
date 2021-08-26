using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Assignment1
{
    public partial class MainPage : ContentPage
    {
        Manager manager = new Manager();
        public MainPage(Manager m)
        {
            InitializeComponent();
            manager = m;
            toppingsList.ItemsSource = manager.toppings;
            sizeList.ItemsSource = manager.sizes;


        }

        public void button1(object sender, EventArgs e)
        {
            quantity.Text = "1";
            manager.quantity = 1;
        }
        public void button2(object sender, EventArgs e)
        {
            quantity.Text = "2";
            manager.quantity = 2;
        }
        public void button3(object sender, EventArgs e)
        {
            quantity.Text = "3";
            manager.quantity = 3;
        }
        public void button4(object sender, EventArgs e)
        {
            quantity.Text = "4";
            manager.quantity = 4;
        }
        public void button5(object sender, EventArgs e)
        {
            quantity.Text = "5";
            manager.quantity = 5;
        }
        public void button6(object sender, EventArgs e)
        {
            quantity.Text = "6";
            manager.quantity = 6;
        }
        public void button7(object sender, EventArgs e)
        {
            quantity.Text = "7";
            manager.quantity = 7;
        }
        public void button8(object sender, EventArgs e)
        {
            quantity.Text = "8";
            manager.quantity = 8;
        }
        public void button9(object sender, EventArgs e)
        {
            quantity.Text = "9";
            manager.quantity = 9;
        }
        public void resetButton(object sender, EventArgs e)
        {
            quantity.Text = "0";
            manager.quantity = 0;
        }

        void addNewPizza (System.Object sender, System.EventArgs e)
        {
            manager.pizzaTot = 0.0;
            if(manager.quantity == 0)
            {
                var msg = "You have not selected any quatity. Please select at least 1 pizza";
                DisplayAlert("Please Select at least 1 Pizza!", msg, "OK");
            }
            else
            {
                if (manager.quantity > 1)
                {
                    manager.totalPrice = manager.totalPrice + manager.quantity * (manager.sizePrice) + manager.quantity * manager.toppingPrice;
                    manager.pizzaTot = manager.quantity * (manager.sizePrice + manager.toppingPrice);
                }
                else
                {
                    manager.totalPrice = manager.totalPrice + manager.sizePrice + manager.toppingPrice;
                    manager.pizzaTot = manager.pizzaTot + manager.sizePrice + manager.toppingPrice;
                }

                manager.currentQuantity = manager.currentQuantity + manager.quantity;

                var newOrder = new OrderCollection(manager.nameTopping, manager.nameSize, manager.currentQuantity, manager.totalPrice, manager.toppingPrice, manager.sizePrice, manager.quantity, manager.pizzaTot);
                manager.addOrder(newOrder);

                var message = "Your order now has " + manager.currentQuantity + " pizza(s), and the total is " + manager.totalPrice + "CND";

                DisplayAlert("Success!", message, "OK");
            }

        }
        void toppingList_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            manager.nameTopping = (e.SelectedItem as Toppings).name;
            toppingLabel.Text = (e.SelectedItem as Toppings).name;
            manager.toppingPrice = (e.SelectedItem as Toppings).price;

        }
        void sizeList_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            manager.nameSize = (e.SelectedItem as Size).size;
            manager.sizePrice = (e.SelectedItem as Size).price;
            sizeLabel.Text = (e.SelectedItem as Size).size;
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuSelectionPage(manager));
        }
    }
}
