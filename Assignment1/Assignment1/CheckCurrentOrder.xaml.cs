using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assignment1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CheckCurrentOrder : ContentPage
    {
        Manager manager;
        public CheckCurrentOrder(Manager m)
        {
            InitializeComponent();
            manager = m;
            orderList.ItemsSource = m.order;
            priceTotal.Text = manager.totalPrice.ToString();
            totalQuantity.Text = manager.currentQuantity.ToString();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {   
            if(manager.totalPrice == 0) { 

                await Navigation.PopAsync();
            }
            else
            {
                DateTime currentDateTime = DateTime.Now;
                var placedOrder = new PlacedOrders(manager.totalPrice, currentDateTime, manager.currentQuantity);
                manager.addFinalOrder(placedOrder);
            }

            manager.order.Clear();
            manager.totalPrice = 0;
            manager.currentQuantity = 0;
            priceTotal.Text = manager.totalPrice.ToString();
            totalQuantity.Text = manager.currentQuantity.ToString();
            await Navigation.PopAsync();
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            var ord = (sender as MenuItem).CommandParameter as OrderCollection;
            manager.totalPrice = manager.totalPrice - ord.pizzaTotal;
            manager.currentQuantity = manager.currentQuantity - ord.pizzaQuantity;
            priceTotal.Text = manager.totalPrice.ToString();
            totalQuantity.Text = manager.currentQuantity.ToString();
            manager.deleteOrder(ord);
        }
    }
}