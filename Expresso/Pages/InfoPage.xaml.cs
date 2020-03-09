using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Expresso.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoPage : ContentPage
    {
        public InfoPage()
        {
            InitializeComponent();
        }

        private void tapFacebook_Tapped(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new Uri("https://www.facebook.com/ContrastCoffeeIronwood"));
        }

        private void tapTwitter_Tapped(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new Uri("https://twitter.com/contrastcoffee?lang=en"));
        }

        private void tapInstagram_Tapped(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new Uri("https://www.instagram.com/contrastcoffee/"));
        }

        private void tapYoutube_Tapped(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new Uri("https://www.youtube.com/watch?v=moVO9Ve4zRo"));
        }

        private void tapPhone_Tapped(object sender, EventArgs e)
        {
            PhoneDialer.Open("9064515662");
        }
    }
}