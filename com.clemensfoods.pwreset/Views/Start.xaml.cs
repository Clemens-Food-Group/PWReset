using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace com.clemensfoods.pwreset.Views
{
    public partial class Start : ContentPage
    {
        public Start()
        {
            InitializeComponent();
        }

        void Enter_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            ProcessEntry();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            EntryTimeCard.Text = "";
            EntryTimeCard.Focus();
        }

        private void EntryTimeCard_TextChanged(object sender, TextChangedEventArgs e)
        {
            ProcessEntry();
        }

        private void ProcessEntry()
        {
            //DisplayAlert("Title", "Text Changed", "OK");
            if (EntryTimeCard.Text.Length > 4 && EntryTimeCard.Text.Length < 6)
            {
                try
                {
                    var result = new Services.REST().RestService(EntryTimeCard);
                    Navigation.PushAsync(new Finish());
                }
                catch(Exception ex)
                {
                    DisplayAlert("Could Not Record Badge!", "Please contact HR if you believe this is incorrect", "OK");
                    EntryTimeCard.Text = "";
                }

            }
        }
    }
}
