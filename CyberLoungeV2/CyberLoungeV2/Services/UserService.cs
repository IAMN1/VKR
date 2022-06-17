using CyberLoungeV2.Models.AuthModels;
using CyberLoungeV2.Models.UserInfoModels;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CyberLoungeV2.Services
{
    //Класс UserService - с помощью
    //которого приложение будет взаимодействовать с сервером
    internal class UserService
    {

        const string Url = "http://192.168.108.86:3000/api/account/"; // обратить внимание на слеш в конце!
        //const string Url = "http://192.168.31.92:3000/api/account/";

        string Result;

        JsonSerializerOptions options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };

        //Настройка клиента
        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        //Обработка регистрации и добавление нового пользователя в БД
        public async Task<string> AddNewUser(User user)
        {
            //отправляем данные на сервер в БД
            HttpClient client = GetClient();

            //отправляем запрос на сервер
            var response = await client.PostAsync(Url,
                new StringContent(
                JsonSerializer.Serialize(user),
                Encoding.UTF8, "application/json"));

            //Отправляем результат попытки регистрации
            switch (response.StatusCode)
            {
                //Если пользователь будет с null параметрами (Маловероятно)
                case HttpStatusCode.NotFound:
                    Result = "Ошибка при регитсрации попробуйте еще раз!";
                    break;
                case HttpStatusCode.BadRequest:
                    Result = "Пользователь с таким Логином уже существует!";
                    break;
                // Регистрация прошла успешно
                case HttpStatusCode.OK:
                    Result = "Пользователь успешно заргеистрирован";
                    break;
            }
            return Result;
        }

        public async Task<string> SignIn(LogIn user)
        {
            //отправляем данные на сервер в БД
            HttpClient client = GetClient();

            //Передать на сервер логин и пароль пользовотеля для входа

            //отправляем запрос на сервер
            var response = await client.PostAsync(Url + "signin/",
                new StringContent(
                JsonSerializer.Serialize(user),
                Encoding.UTF8, "application/json"));

            //Отправляем результат попытки Авторизации
            switch (response.StatusCode)
            {
                //Если пользователь будет с null параметрами (Маловероятно)
                // или не будет найдет
                case HttpStatusCode.BadRequest:
                    Result = "Неверный логин или пароль!";
                    break;
                case HttpStatusCode.NotFound:
                    Result = "Неверный логин или пароль!";
                    break;

                //Регистрация прошла успешно
                case HttpStatusCode.OK:
                    Result = "Пользователь успешно авторизирован";
                    break;
            }
            return Result;
        }

        public async Task<UserData>GetUserInfo(string Login)
        {
            //отправляем данные на сервер в БД
            HttpClient client = GetClient();

            //Передать на сервер логин и пароль пользовотеля для входа

            //отправляем запрос на сервер
            var response = await client.PostAsync(Url + "userinfo/" + Login,
                new StringContent(
                JsonSerializer.Serialize(Login),
                Encoding.UTF8, "application/json"));

            //Отправляем результат попытки Авторизации
            if(response.StatusCode != HttpStatusCode.OK)
            {
                return null;
            }

            return JsonSerializer.Deserialize<UserData>(
                    await response.Content.ReadAsStringAsync(), options);
        }

        public async Task<string> SendChangePassword(LogIn model)
        {

            string Login = model.Login;

            //отправляем данные на сервер в БД
            HttpClient client = GetClient();

            //отправляем запрос на сервер
            var response = await client.PutAsync(Url,
                new StringContent(
                JsonSerializer.Serialize(model),
                Encoding.UTF8, "application/json"));
             if(response.StatusCode != HttpStatusCode.OK)
            {
                return "Ошибка, повторите попытку позже!";
            }
            else
            {
                return "Ваш пароль был успешно изменен!";
            }
        }
    }
}
