using CyberLoungeV2.Views.MainContent;
using CyberLoungeV2.Views.MainContent.NewsViews;
using System.Windows.Input;
using Xamarin.Forms;

namespace CyberLoungeV2.ViewModels.NewsViewModels
{
    public class NewsViewModel
    {
        //Команды для перехода на другие страницы
        public ICommand OnSalesCommand { get; set; }
        public ICommand OnPricesCommand { get; set; }
        public ICommand OnDepositCommand { get; set; }
        public ICommand OnTournamentsTapped { get; set; }

        //для перехода по страницам через Navigation
        public INavigation Navigation { get; set; }

        public NewsViewModel()
        {
            OnSalesCommand = new Command(OnSales);
            OnPricesCommand = new Command(OnPrices);
        }

        private async void OnSales()
        {
            await Navigation.PushModalAsync(new SalesPage());
        }

        private async void OnPrices()
        {
            await Navigation.PushModalAsync(new PricesPage());
        }

        private async void OnTournaments()
        {
            await Navigation.PushAsync(new TournamentsPage());
        }

        public async void ClickedOnProfile()
        {
            await Navigation.PushAsync(new ProfilePage());
        }
    }
}
