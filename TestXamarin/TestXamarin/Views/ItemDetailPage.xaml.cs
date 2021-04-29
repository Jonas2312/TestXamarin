using System.ComponentModel;
using TestXamarin.ViewModels;
using Xamarin.Forms;

namespace TestXamarin.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}