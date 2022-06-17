using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CyberLoungeV2.ViewModels.AuthorizationViewModel;

namespace CyberLoungeV2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        LoginViewModel LoginViewModel;
        
        public LoginPage()
        {
            InitializeComponent();

            LoginViewModel = new LoginViewModel() { Navigation = Navigation };

            //Привязка полей ввода к модели authviewModel.loginModel
            Binding LoginValue = new Binding { Source = LoginViewModel.LoginModel, Path = "Login" };
            LoginEntry.SetBinding(Entry.TextProperty, LoginValue);
            Binding PasswordValue = new Binding { Source = LoginViewModel.LoginModel, Path = "Password" };
            PasswordEntry.SetBinding(Entry.TextProperty, PasswordValue);

            RegistrationBtn.Clicked += ToRegistrationPage;
            LoginBtn.Clicked += ToSignIn;

        }

        private async void ToSignIn(object sender, EventArgs e)
        {
            string Login, Password;
            Login = LoginEntry.Text;
            Password = PasswordEntry.Text;

            if (Login != null && Password != null)
            {
                await LoginViewModel.SignIn(LoginViewModel.LoginModel);

            }
            else
            {
                await DisplayAlert("Внимание!", "Неправильный логин или пароль!", "Ok");
            }
        }

        private async void ToRegistrationPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationPage());
        }
    }
}