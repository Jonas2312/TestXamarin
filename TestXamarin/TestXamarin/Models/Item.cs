using System;
using Xamarin.Forms;

namespace TestXamarin.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }

        public ImageSource Photo { get; set; }
    }
}