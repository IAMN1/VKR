using CyberLoungeV2.Services;
using System.Collections.Generic;
using CyberLoungeV2.Models.ReservationModels;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CyberLoungeV2.ViewModels.PlaceViewModels
{
    public class PlaceViewModel : INotifyPropertyChanged
    {
        const string ErrorMessage = "Ошибка, повторите попытку позже!"; 
        // Статус начальной инициализации

        // Статус загрузки с сервера
        private bool isBusy;

        string Result;

        //Список  о местах забронированных клиентом
        public List<Reservation> reservationList = new List<Reservation>();
        
        //Для заполнения списка мест и их броней
        public ObservableCollection<Place> Places { get; set; }

        public ReservationService reservationService;

        public INavigation Navigation { get; set; }


        private Command refreshViewCommand;


        public event PropertyChangedEventHandler PropertyChanged;

        public PlaceViewModel()
        {
            Places = new ObservableCollection<Place>();
            reservationService = new ReservationService();
        }

        public Command RefreshViewCommand
        {
            get
            {
                return refreshViewCommand ?? (refreshViewCommand = new Command(() =>
                {
                    IsBusy = true;
                    this.RefreshData();
                }));
            }
        }

        private async void RefreshData()
        {
            await  GetPlaces();
            this.IsBusy = false;
        }

        //Изменения статуса при загрузке данных с сервера
        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;
                OnPropertyChanged("IsBusy");
                OnPropertyChanged("IsLoaded");
            }
        }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
        
        //Загрузка данных с сервера о местах и их статусе брони 
        public async Task GetPlaces()
        {
            IsBusy = true;

            IEnumerable<Place> place =  await reservationService.GetPlace();
            while (Places.Any())
                Places.RemoveAt(Places.Count - 1);

            foreach (Place p in place)
                Places.Add(p);

            IsBusy = false;
        }

        public async Task<string> ReservatePlaces(List<Reservation> reservationList)
        {
            if( reservationList != null)
            {
                Result = await reservationService.SendReservation(reservationList);
            }

            if(Result == ErrorMessage)
            {
                return Result;
            }
            else
            {
                return "Бронь прошла успешно!";
            }
        }
    }
}
