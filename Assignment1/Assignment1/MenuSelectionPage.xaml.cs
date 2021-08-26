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
    public partial class MenuSelectionPage : ContentPage
    {
        Manager manager;
        public MenuSelectionPage(Manager m)
        {
            InitializeComponent();
            manager = m;
        }
        async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CheckCurrentOrder(manager));
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PreviousOrders(manager));
        }

        async void Button_Clicked_3(object sender, EventArgs e)
        {
            manager.order.Clear();
            manager.totalPrice = 0;
            manager.currentQuantity = 0;
            await Navigation.PopAsync();
        }
    }
}