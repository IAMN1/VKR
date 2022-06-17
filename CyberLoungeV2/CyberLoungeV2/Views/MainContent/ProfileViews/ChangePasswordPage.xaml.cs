using CyberLoungeV2.ViewModels.ProfileViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CyberLoungeV2.Views.MainContent.Profile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChangePasswordPage : ContentPage
    {
        ChangePasswordPageViewModel viewModel;
        public ChangePasswordPage()
        {
            InitializeComponent();

            viewModel = new ChangePasswordPageViewModel();

            Binding ChangPassEntry = new Binding { Source = viewModel.LoginModel, Path="Password"};
            ChangingPasswordEntry.SetBinding(Entry.TextProperty, ChangPassEntry);
        }

        public  async void ButtonClicked(object sender, EventArgs e)
        {
            string password = ChangingPasswordEntry.Text;
            if (password == null)
            {
                await DisplayAlert("", "Введите пароль!", "Ок");
            }
            else 
            {
                try
                {
                    viewModel.LoginModel.Login = (Shell.Current as AppShell).UserData.Login;
                    await viewModel.ChangePassword(viewModel.LoginModel);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    await Navigation.PopModalAsync();
                }
            }
        }
    }
}