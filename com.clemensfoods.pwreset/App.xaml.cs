using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using com.clemensfoods.pwreset.Services;
using com.clemensfoods.pwreset.Views;

namespace com.clemensfoods.pwreset
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new Start());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
