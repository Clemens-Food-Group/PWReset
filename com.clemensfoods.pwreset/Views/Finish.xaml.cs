using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace com.clemensfoods.pwreset.Views
{
    public partial class Finish : ContentPage
    {
        public Finish()
        {
            InitializeComponent();
        }

        void Exit_Button_Clicked(System.Object sender, System.EventArgs e)
        {

            Navigation.PopToRootAsync();

        }
    }
}
