using System.ComponentModel;
using Xamarin.Forms;
using CustomizeFont.ViewModels;

namespace CustomizeFont.Views
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