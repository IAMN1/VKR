using CyberLoungeV2.Models.UserInfoModels;
using CyberLoungeV2.Services;
using CyberLoungeV2.ViewModels.AuthorizationViewModels;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CyberLoungeV2.ViewModels.AuthorizationViewModel
{
    internal class RegistrationViewModel
    {
        //const string ErrorMessage = "Неверный логин или пароль!";
        //const string SignInComplete = "Пользователь успешно авторизирован";
        string Result;
        string hashPass = "";

        // Создаем объекты используемых моделией
        public User User { get; set; }
        public CryptingViewModel Crypting { get; set; }
        public INavigation Navigation { get; set; }

        UserService uService = new UserService(); //Для взаимодействия с сервером

        public RegistrationViewModel()
        {
            User = new User();
            Crypting = new CryptingViewModel();
        }

        //Метод регистрации
        public async Task<string> RegistrationUser(object usrObj)
        {
            User usr = usrObj as User;
            if (usr != null)
            {
                try
                {
                    hashPass = Crypting.CryptingPass(usr.Password);
                    usr.Password = hashPass;
                    Result = await uService.AddNewUser(usr);
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                throw new Exception(usr + "is null");
            }
            await Navigation.PopAsync();
            return Result;
        }
    }
}
