using CyberLoungeV2.Models.UserInfoModels;
using CyberLoungeV2.Views;
using CyberLoungeV2.Views.MainContent;
using System;
using Xamarin.Forms;

namespace CyberLoungeV2
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        // сохраняем логин пользователя
        public UserData UserData;
        public AppShell(UserData login_data)
        {
            InitializeComponent();
            
            UserData = login_data;

            Routing.RegisterRoute(nameof(NewsPage), typeof(NewsPage));
            Routing.RegisterRoute(nameof(ReservationPage), typeof(ReservationPage));
        }

        private async void LogoutClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}
