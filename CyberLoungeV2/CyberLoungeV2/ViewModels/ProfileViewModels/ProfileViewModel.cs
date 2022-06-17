using CyberLoungeV2.Models.UserInfoModels;
using CyberLoungeV2.Views.MainContent.Profile;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CyberLoungeV2.ViewModels.ProfileViewModels
{
    public class ProfileViewModel
    {
        public List<UserProfile> ProfileList { get; set; }

        public INavigation Navigation { get; set; }
        public ProfileViewModel()
        {
            CreateUserProfileList();
        }
        public List<UserProfile> CreateUserProfileList()
        {
            ProfileList = new List<UserProfile>
            {
                new UserProfile { ValueVariable =  (Shell.Current as AppShell).UserData.Email, ImagePath="Email.png" },
                new UserProfile { ValueVariable = "О приложении",ImagePath="About.png" },
                new UserProfile { ValueVariable = "Наш Состав по CSGO", ImagePath="CSGO.png" },
                new UserProfile { ValueVariable = "Наш Состав по Dota 2", ImagePath="Dota.png"},
                new UserProfile { ValueVariable = "Выход", ImagePath = "" }
            };
            return ProfileList;
        }

        public async void ChangePassword()
        {
            await Navigation.PushModalAsync(new ChangePasswordPage());
        }
    }
}
