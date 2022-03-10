using System.ComponentModel;
using Xamarin.Forms;
using com.clemensfoods.pwreset.ViewModels;

namespace com.clemensfoods.pwreset.Views
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
