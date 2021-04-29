using System;
using System.Collections.Generic;
using TestXamarin.ViewModels;
using TestXamarin.Views;
using Xamarin.Forms;

namespace TestXamarin
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
