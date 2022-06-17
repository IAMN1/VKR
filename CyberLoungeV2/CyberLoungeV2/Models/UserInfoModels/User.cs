using System;

namespace CyberLoungeV2.Models.UserInfoModels
{
    // Класс Users - основная модель
    // авторизации нашего приложения

    //Чтобы наш класс мог сериализовываться
    [Serializable]
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public override bool Equals(object obj)
        {
            User user = obj as User;
            return this.Id == user.Id;
        }
    }
}
