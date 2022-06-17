using CyberLoungeV2.Models.UserInfoModels;
using CyberLoungeV2.ViewModels.ProfileViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CyberLoungeV2.Views.MainContent
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        ProfileViewModel ProfileViewModel;

        public ProfilePage()
        {
            ProfileViewModel = new ProfileViewModel { Navigation = Navigation};

            InitializeComponent();
            
            lblLogin.Text = (Shell.Current as AppShell).UserData.Login;
            lblname.Text = (Shell.Current as AppShell).UserData.Name;

            ProfileList.BindingContext = ProfileViewModel;
        }

        private async void OnItemUserInfoSelected(object sender, SelectedItemChangedEventArgs args)
        {
            // Получаем выбранный элемент 
            var selectItem = args.SelectedItem as UserProfile;
            if (selectItem != null)
            {
                if (selectItem.ValueVariable == "Выход")
                {
                    Application.Current.MainPage = new NavigationPage(new LoginPage());
                }
                // Снимаем выделение
                ProfileList.SelectedItem = null;
            }
        }

        private void EditProfileCommand(object sender, EventArgs e)
        {
            ProfileViewModel.ChangePassword();
        }
    }
}