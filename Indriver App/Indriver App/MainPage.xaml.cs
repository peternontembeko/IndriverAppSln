using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Indriver_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        //  await Task.Delay(6000);

        //            await Navigation.PushAsync(new LoginPage());
    }

    private async void LoginButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }
}


}

