using Expresso.Models;
using Expresso.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace Expresso.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReservationPage : ContentPage
    {
        public ReservationPage()
        {
            InitializeComponent();
        }

        private async void btnSubmit_Clicked(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation()
            {
                Name = txtName.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text,
                TotalPeople = Int32.Parse(txtTotalPeople.Text),
                Date = dpBookingDate.Date,
                Time = tpBookingTime.Time.ToString()
            };
            ApiServices apiServices = new ApiServices();
            bool response = await apiServices.ReserveTable(reservation);
            if(response != true)
            {
                await DisplayAlert("Error", "Something went wrong!", "Close");
            }
            else
            {
                await DisplayAlert("Success", "Your reservation was received!", "OK");
            }
        }
    }
}