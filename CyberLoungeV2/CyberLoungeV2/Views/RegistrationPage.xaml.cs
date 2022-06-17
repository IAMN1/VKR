using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using CyberLoungeV2.ViewModels.AuthorizationViewModel;

namespace CyberLoungeV2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {

        RegistrationViewModel RegistrationViewModel;

        public RegistrationPage()
        {
            InitializeComponent();

           RegistrationViewModel = new RegistrationViewModel() { Navigation = Navigation };

            Binding LoginValue = new Binding { Source = RegistrationViewModel.User, Path = "Login" };
            LoginEntry.SetBinding(Entry.TextProperty, LoginValue);
            Binding NameValue = new Binding { Source = RegistrationViewModel.User, Path = "Name" };
            NameEntry.SetBinding(Entry.TextProperty, NameValue);
            Binding EmailValue = new Binding { Source = RegistrationViewModel.User, Path = "Email" };
            EmailEntry.SetBinding(Entry.TextProperty, EmailValue);
            Binding PasswordValue = new Binding { Source = RegistrationViewModel.User, Path = "Password" };
            PasswordEntry.SetBinding(Entry.TextProperty, PasswordValue);
        }

        private async void RegistrateClicked(object sender, EventArgs e)
        {
            string result;
            //для проверки на корректность ввода данных
            string Login, Name, Email, Password;
            Login = LoginEntry.Text;
            Name = NameEntry.Text;
            Email = EmailEntry.Text;
            Password = PasswordEntry.Text;

            //Проверка на корректность данных
            if (Login != null && Name != null &&
               Email != null && Password != null)
            {
                if (PasswordEntry.Text != ConfirmPasswordEntry.Text)
                {
                    await DisplayAlert("Ошибка", "Пароль не совпадает!", "Ok");
                }
                else
                {
                    result = await RegistrationViewModel.RegistrationUser(RegistrationViewModel.User);
                    await DisplayAlert("", result, "Ok");
                }
            }
            else
                await DisplayAlert("Ошибка", "Не все данные введены коректно!", "Ok");
        }
    }
}