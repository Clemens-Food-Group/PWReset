using System;
using System.Collections.Generic;
using com.clemensfoods.pwreset.ViewModels;
using com.clemensfoods.pwreset.Views;
using Xamarin.Forms;

namespace com.clemensfoods.pwreset
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
