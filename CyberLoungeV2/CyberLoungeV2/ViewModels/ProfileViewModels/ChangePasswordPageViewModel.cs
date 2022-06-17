using CyberLoungeV2.Models.AuthModels;
using CyberLoungeV2.Services;
using CyberLoungeV2.ViewModels.AuthorizationViewModels;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CyberLoungeV2.ViewModels.ProfileViewModels
{
    public class ChangePasswordPageViewModel
    {
        public LogIn LoginModel;

        CryptingViewModel Crypting;

        string hashNewPass = "";

        //для перехода по страницам через Navigation
        public INavigation Navigation { get; set; }

        UserService uService = new UserService();
        public ChangePasswordPageViewModel()
        {
            LoginModel = new LogIn();
            Crypting  = new CryptingViewModel();
        }

        public async Task ChangePassword(LogIn model)
        {
            hashNewPass = Crypting.CryptingPass(model.Password);
            model.Password = hashNewPass;
            await uService.SendChangePassword(model);
        }
    }
}
