namespace CyberLoungeV2.Models.UserInfoModels
{
    //Модель для получения данных о пользователе с сервера
    public class UserData
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Deposit { get; set; }
    }
}
