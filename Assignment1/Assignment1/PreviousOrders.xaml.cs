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
    public partial class PreviousOrders : ContentPage
    {
        Manager manager;
        public PreviousOrders(Manager m)
        {
            InitializeComponent();
            manager = m;
            placeOrderList.ItemsSource = m.placeOrder;
        }
    }
}