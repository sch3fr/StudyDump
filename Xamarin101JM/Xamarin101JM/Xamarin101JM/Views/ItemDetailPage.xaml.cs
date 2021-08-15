using System.ComponentModel;
using Xamarin.Forms;
using Xamarin101JM.ViewModels;

namespace Xamarin101JM.Views
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