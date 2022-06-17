using System;
using Xamarin.Forms;
using System.Threading.Tasks;
using CyberLoungeV2.Services;
using CyberLoungeV2.Views.MainContent;
using CyberLoungeV2.Models.UserInfoModels;
using CyberLoungeV2.Models.AuthModels;
using CyberLoungeV2.ViewModels.AuthorizationViewModels;

namespace CyberLoungeV2.ViewModels.AuthorizationViewModel
{
    // Класс  AuthViewModel через который будет совершаться взаимодейстие
    // графического интерфейса и веб сервера

    public class LoginViewModel 
    {
        string hashPass = "";
        const string ErrorMessage = "Неверный логин или пароль!";
        const string SignInComplete = "Пользователь успешно авторизирован";
        string Result;

        // Создаем объекты используемых моделей
        public User User { get; set; }
        public LogIn LoginModel { get; set; }
        
        public CryptingViewModel crypting { get; set; }

        //для перехода по страницам через Navigation
        public INavigation Navigation { get; set; }

        UserService uService = new UserService(); //Для взаимодействия с сервером

        public LoginViewModel()
        {
            User = new User();
            LoginModel = new LogIn();
            crypting = new CryptingViewModel();
        }

        //Метод авторизации
        public async Task<string> SignIn(Object SignInObj)
        {
            LogIn usr = SignInObj as LogIn;

            if (usr != null)
            {
                try
                {
                    hashPass = crypting.CryptingPass(usr.Password);
                    usr.Password = hashPass;

                    Result = await uService.SignIn(usr);
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                throw new Exception("Ошибка с входом");
            }

            if (Result == ErrorMessage)
            {
                return Result;
            }
            else
            {
                //Передаем Логин пользователя на новостную страницу, а затем на страницу профиля     
                string Login_data = usr.Login;
                
                //Получаем необходимую информацию по логину
                UserData UserData = await uService.GetUserInfo(Login_data);

                //Сохраняем полученные данные с сервера в главном файле приложения
                Application.Current.MainPage = new AppShell(UserData);

                await Shell.Current.GoToAsync($"//{nameof(NewsPage)}");

                return null;
            }
        }
    }
}
