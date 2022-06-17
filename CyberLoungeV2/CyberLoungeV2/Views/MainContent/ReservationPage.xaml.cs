using CyberLoungeV2.Models.ReservationModels;
using CyberLoungeV2.ViewModels.PlaceViewModels;
using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CyberLoungeV2.Views.MainContent
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReservationPage : ContentPage
    {
        //Цвета для обозначения статуса мест
        public const string ColorGreen = "#B5E61D";
        public const string ColorRed = "#FF3737";
        public const string ColorPink = "#EA3FF7";

        public PlaceViewModel viewModel;

        public Color TempColor = Color.FromHex(ColorGreen);
        public ReservationPage()
        {
            viewModel = new PlaceViewModel { Navigation = Navigation };
            InitializeComponent();
            BindingContext = viewModel;
        }
        //Обновляю информацию о местах при старте страницы
        protected async override void OnAppearing()
        {
            //Очищаем список бронирования мест пользователя
            viewModel.reservationList.Clear();

            await viewModel.GetPlaces();

            foreach (Place p in viewModel.Places)
            {
                switch (p.NumberPlace)
                {
                    case "1":
                        {
                            if (p.IsBusy == 0)
                            {
                                F1.BackgroundColor = Color.FromHex(ColorGreen);

                            }
                            else if (p.IsBusy == 1)
                            {
                                F1.BackgroundColor = Color.FromHex(ColorPink);
                                F1.IsEnabled = false;
                            }
                            else
                            {
                                F1.BackgroundColor = Color.FromHex(ColorRed);
                                F1.IsEnabled = false;
                            }
                            break;
                        }
                    case "2":
                        {
                            if (p.IsBusy == 0)
                            {
                                F2.BackgroundColor = Color.FromHex(ColorGreen);
                            }
                            else if (p.IsBusy == 1)
                            {
                                F2.BackgroundColor = Color.FromHex(ColorPink);
                                F2.IsEnabled = false;
                            }
                            else
                            {
                                F2.BackgroundColor = Color.FromHex(ColorRed);
                                F2.IsEnabled = false;
                            }
                            break;
                        }
                    case "3":
                        {
                            if (p.IsBusy == 0)
                            {
                                F3.BackgroundColor = Color.FromHex(ColorGreen);
                            }
                            else if (p.IsBusy == 1)
                            {
                                F3.BackgroundColor = Color.FromHex(ColorPink);
                                F3.IsEnabled = false;
                            }
                            else
                            {
                                F3.BackgroundColor = Color.FromHex(ColorRed);
                                F3.IsEnabled = false;
                            }
                            break;
                        }
                    case "4":
                        {
                            if (p.IsBusy == 0)
                            {
                                F4.BackgroundColor = Color.FromHex(ColorGreen);
                            }
                            else if (p.IsBusy == 1)
                            {
                                F4.BackgroundColor = Color.FromHex(ColorPink);
                                F4.IsEnabled = false;
                            }
                            else
                            {
                                F4.BackgroundColor = Color.FromHex(ColorRed);
                                F4.IsEnabled = false;
                            }
                            break;
                        }
                    case "5":
                        {
                            if (p.IsBusy == 0)
                            {
                                F5.BackgroundColor = Color.FromHex(ColorGreen);
                            }
                            else if (p.IsBusy == 1)
                            {
                                F5.BackgroundColor = Color.FromHex(ColorPink);
                                F5.IsEnabled = false;
                            }
                            else
                            {
                                F5.BackgroundColor = Color.FromHex(ColorRed);
                                F5.IsEnabled = false;
                            }
                            break;
                        }
                    case "6":
                        {
                            if (p.IsBusy == 0)
                            {
                                F6.BackgroundColor = Color.FromHex(ColorGreen);
                            }
                            else if (p.IsBusy == 1)
                            {
                                F6.BackgroundColor = Color.FromHex(ColorPink);
                                F6.IsEnabled = false;
                            }
                            else
                            {
                                F6.BackgroundColor = Color.FromHex(ColorRed);
                                F6.IsEnabled = false;
                            }
                            break;
                        }
                    case "7":
                        {
                            if (p.IsBusy == 0)
                            {
                                F7.BackgroundColor = Color.FromHex(ColorGreen);
                            }
                            else if (p.IsBusy == 1)
                            {
                                F7.BackgroundColor = Color.FromHex(ColorPink);
                                F7.IsEnabled = false;
                            }
                            else
                            {
                                F7.BackgroundColor = Color.FromHex(ColorRed);
                                F7.IsEnabled = false;
                            }
                            break;
                        }
                    case "8":
                        {
                            if (p.IsBusy == 0)
                            {
                                F8.BackgroundColor = Color.FromHex(ColorGreen);
                            }
                            else if (p.IsBusy == 1)
                            {
                                F8.BackgroundColor = Color.FromHex(ColorPink);
                                F8.IsEnabled = false;
                            }
                            else
                            {
                                F8.BackgroundColor = Color.FromHex(ColorRed);
                                F8.IsEnabled = false;
                            }
                            break;
                        }
                    case "9":
                        {
                            if (p.IsBusy == 0)
                            {
                                F9.BackgroundColor = Color.FromHex(ColorGreen);
                            }
                            else if (p.IsBusy == 1)
                            {
                                F9.BackgroundColor = Color.FromHex(ColorPink);
                                F9.IsEnabled = false;
                            }
                            else
                            {
                                F9.BackgroundColor = Color.FromHex(ColorRed);
                                F9.IsEnabled = false;
                            }
                            break;
                        }
                    case "10":
                        {
                            if (p.IsBusy == 0)
                            {
                                F10.BackgroundColor = Color.FromHex(ColorGreen);
                            }
                            else if (p.IsBusy == 1)
                            {
                                F10.BackgroundColor = Color.FromHex(ColorPink);
                                F10.IsEnabled = false;
                            }
                            else
                            {
                                F10.BackgroundColor = Color.FromHex(ColorRed);
                                F10.IsEnabled = false;
                            }
                            break;
                        }
                    case "11":
                        {
                            if (p.IsBusy == 0)
                            {
                                F11.BackgroundColor = Color.FromHex(ColorGreen);

                            }
                            else if (p.IsBusy == 1)
                            {
                                F11.BackgroundColor = Color.FromHex(ColorPink);
                                F11.IsEnabled = false;
                            }
                            else
                            {
                                F11.BackgroundColor = Color.FromHex(ColorRed);
                                F11.IsEnabled = false;
                            }
                            break;
                        }
                    case "12":
                        {
                            if (p.IsBusy == 0)
                            {
                                F12.BackgroundColor = Color.FromHex(ColorGreen);

                            }
                            else if (p.IsBusy == 1)
                            {
                                F12.BackgroundColor = Color.FromHex(ColorPink);
                                F12.IsEnabled = false;
                            }
                            else
                            {
                                F12.BackgroundColor = Color.FromHex(ColorRed);
                                F12.IsEnabled = false;
                            }
                            break;
                        }
                    case "13":
                        {
                            if (p.IsBusy == 0)
                            {
                                F13.BackgroundColor = Color.FromHex(ColorGreen);

                            }
                            else if (p.IsBusy == 1)
                            {
                                F13.BackgroundColor = Color.FromHex(ColorPink);
                                F13.IsEnabled = false;
                            }
                            else
                            {
                                F13.BackgroundColor = Color.FromHex(ColorRed);
                                F13.IsEnabled = false;
                            }
                            break;
                        }
                    case "14":
                        {
                            if (p.IsBusy == 0)
                            {
                                F14.BackgroundColor = Color.FromHex(ColorGreen);

                            }
                            else if (p.IsBusy == 1)
                            {
                                F14.BackgroundColor = Color.FromHex(ColorPink);
                                F14.IsEnabled = false;
                            }
                            else
                            {
                                F14.BackgroundColor = Color.FromHex(ColorRed);
                                F14.IsEnabled = false;
                            }
                            break;
                        }
                    case "15":
                        {
                            if (p.IsBusy == 0)
                            {
                                F15.BackgroundColor = Color.FromHex(ColorGreen);

                            }
                            else if (p.IsBusy == 1)
                            {
                                F15.BackgroundColor = Color.FromHex(ColorPink);
                                F15.IsEnabled = false;
                            }
                            else
                            {
                                F1.BackgroundColor = Color.FromHex(ColorRed);
                                F15.IsEnabled = false;
                            }
                            break;
                        }
                    case "16":
                        {
                            if (p.IsBusy == 0)
                            {
                                F16.BackgroundColor = Color.FromHex(ColorGreen);

                            }
                            else if (p.IsBusy == 1)
                            {
                                F16.BackgroundColor = Color.FromHex(ColorPink);
                                F16.IsEnabled = false;
                            }
                            else
                            {
                                F16.BackgroundColor = Color.FromHex(ColorRed);
                                F16.IsEnabled = false;
                            }
                            break;
                        }
                    case "17":
                        {
                            if (p.IsBusy == 0)
                            {
                                F17.BackgroundColor = Color.FromHex(ColorGreen);

                            }
                            else if (p.IsBusy == 1)
                            {
                                F17.BackgroundColor = Color.FromHex(ColorPink);
                                F17.IsEnabled = false;
                            }
                            else
                            {
                                F17.BackgroundColor = Color.FromHex(ColorRed);
                                F17.IsEnabled = false;
                            }
                            break;
                        }
                    case "18":
                        {
                            if (p.IsBusy == 0)
                            {
                                F18.BackgroundColor = Color.FromHex(ColorGreen);

                            }
                            else if (p.IsBusy == 1)
                            {
                                F18.BackgroundColor = Color.FromHex(ColorPink);
                                F18.IsEnabled = false;
                            }
                            else
                            {
                                F18.BackgroundColor = Color.FromHex(ColorRed);
                                F18.IsEnabled = false;
                            }
                            break;
                        }
                    case "19":
                        {
                            if (p.IsBusy == 0)
                            {
                                F19.BackgroundColor = Color.FromHex(ColorGreen);

                            }
                            else if (p.IsBusy == 1)
                            {
                                F19.BackgroundColor = Color.FromHex(ColorPink);
                                F19.IsEnabled = false;
                            }
                            else
                            {
                                F19.BackgroundColor = Color.FromHex(ColorRed);
                                F19.IsEnabled = false;
                            }
                            break;
                        }
                    case "20":
                        {
                            if (p.IsBusy == 0)
                            {
                                F20.BackgroundColor = Color.FromHex(ColorGreen);

                            }
                            else if (p.IsBusy == 1)
                            {
                                F20.BackgroundColor = Color.FromHex(ColorPink);
                                F20.IsEnabled = false;
                            }
                            else
                            {
                                F20.BackgroundColor = Color.FromHex(ColorRed);
                                F20.IsEnabled = false;
                            }
                            break;
                        }
                }
            }
            base.OnAppearing();
        }

        //Обработка нажатия кнопки бронирования
        private async void OnButtonClicked(object sender, EventArgs e)
        {
            string result;

            //Отправка выбранных для бронироания мест на сервер
            result = await viewModel.reservationService.SendReservation(viewModel.reservationList);

            OnAppearing();

            //Вывод результата бронироания
            await DisplayAlert("", result, "Ok");
        }

        private void OnTapped1(object sender, EventArgs e)
        {
            if (((Frame)sender).BackgroundColor == TempColor)
            {
                ((Frame)sender).BackgroundColor = Color.Yellow;

                //Если пользователь отметил место для юронирования, то помещаем его в список
                viewModel.reservationList.Add(
                    new Reservation
                    {
                        UserLogin = (Shell.Current as AppShell).UserData.Login,
                        PlaceId = viewModel.Places[0].Id,
                        IsBusy = 1 //Меняем статус места на забронированное
                    });
            }
            else
            {
                ((Frame)sender).BackgroundColor = TempColor;

                //Если пользователь отменил бронирование данного места, то удаляем объект из списка
                var item = viewModel.reservationList.FirstOrDefault(x => x.PlaceId == 1);
                viewModel.reservationList.Remove(item);
            }
        }
        private void OnTapped2(object sender, EventArgs e)
        {
            if (((Frame)sender).BackgroundColor == TempColor)
            {
                ((Frame)sender).BackgroundColor = Color.Yellow;

                viewModel.reservationList.Add(
                    new Reservation
                    {
                        UserLogin = (Shell.Current as AppShell).UserData.Login,
                        PlaceId = viewModel.Places[1].Id,
                        IsBusy = 1 //Меняем статус места на забронированное
                    });
            }
            else
            {
                ((Frame)sender).BackgroundColor = TempColor;

                var item = viewModel.reservationList.FirstOrDefault(x => x.PlaceId == 2);
                viewModel.reservationList.Remove(item);
            }
        }
        private void OnTapped3(object sender, EventArgs e)
        {
            if (((Frame)sender).BackgroundColor == TempColor)
            {
                ((Frame)sender).BackgroundColor = Color.Yellow;

                viewModel.reservationList.Add(
                    new Reservation
                    {
                        UserLogin = (Shell.Current as AppShell).UserData.Login,
                        PlaceId = viewModel.Places[2].Id,
                        IsBusy = 1 //Меняем статус места на забронированное
                    });
            }
            else
            {
                ((Frame)sender).BackgroundColor = TempColor;

                var item = viewModel.reservationList.FirstOrDefault(x => x.PlaceId == 3);
                viewModel.reservationList.Remove(item);
            }
        }
        private void OnTapped4(object sender, EventArgs e)
        {
            if (((Frame)sender).BackgroundColor == TempColor)
            {
                ((Frame)sender).BackgroundColor = Color.Yellow;

                viewModel.reservationList.Add(
                    new Reservation
                    {
                        UserLogin = (Shell.Current as AppShell).UserData.Login,
                        PlaceId = viewModel.Places[3].Id,
                        IsBusy = 1 //Меняем статус места на забронированное
                    });
            }
            else
            {
                ((Frame)sender).BackgroundColor = TempColor;

                var item = viewModel.reservationList.FirstOrDefault(x => x.PlaceId == 4);
                viewModel.reservationList.Remove(item);
            }
        }
        private void OnTapped5(object sender, EventArgs e)
        {
            if (((Frame)sender).BackgroundColor == TempColor)
            {
                ((Frame)sender).BackgroundColor = Color.Yellow;

                viewModel.reservationList.Add(
                    new Reservation
                    {
                        UserLogin = (Shell.Current as AppShell).UserData.Login,
                        PlaceId = viewModel.Places[4].Id,
                        IsBusy = 1 //Меняем статус места на забронированное
                    });
            }
            else
            {
                ((Frame)sender).BackgroundColor = TempColor;

                var item = viewModel.reservationList.FirstOrDefault(x => x.PlaceId == 5);
                viewModel.reservationList.Remove(item);
            }
        }
        private void OnTapped6(object sender, EventArgs e)
        {
            if (((Frame)sender).BackgroundColor == TempColor)
            {
                ((Frame)sender).BackgroundColor = Color.Yellow;

                viewModel.reservationList.Add(
                    new Reservation
                    {
                        UserLogin = (Shell.Current as AppShell).UserData.Login,
                        PlaceId = viewModel.Places[5].Id,
                        IsBusy = 1 //Меняем статус места на забронированное
                    });
            }
            else
            {
                ((Frame)sender).BackgroundColor = TempColor;

                var item = viewModel.reservationList.FirstOrDefault(x => x.PlaceId == 6);
                viewModel.reservationList.Remove(item);
            }
        }
        private void OnTapped7(object sender, EventArgs e)
        {
            if (((Frame)sender).BackgroundColor == TempColor)
            {
                ((Frame)sender).BackgroundColor = Color.Yellow;

                viewModel.reservationList.Add(
                    new Reservation
                    {
                        UserLogin = (Shell.Current as AppShell).UserData.Login,
                        PlaceId = viewModel.Places[6].Id,
                        IsBusy = 1 //Меняем статус места на забронированное
                    });
            }
            else
            {
                ((Frame)sender).BackgroundColor = TempColor;

                var item = viewModel.reservationList.FirstOrDefault(x => x.PlaceId == 7);
                viewModel.reservationList.Remove(item);
            }
        }
        private void OnTapped8(object sender, EventArgs e)
        {
            if (((Frame)sender).BackgroundColor == TempColor)
            {
                ((Frame)sender).BackgroundColor = Color.Yellow;

                viewModel.reservationList.Add(
                    new Reservation
                    {
                        UserLogin = (Shell.Current as AppShell).UserData.Login,
                        PlaceId = viewModel.Places[7].Id,
                        IsBusy = 1 //Меняем статус места на забронированное
                    });
            }
            else
            {
                ((Frame)sender).BackgroundColor = TempColor;

                var item = viewModel.reservationList.FirstOrDefault(x => x.PlaceId == 8);
                viewModel.reservationList.Remove(item);
            }
        }
        private void OnTapped9(object sender, EventArgs e)
        {

            if (((Frame)sender).BackgroundColor == TempColor)
            {
                ((Frame)sender).BackgroundColor = Color.Yellow;

                viewModel.reservationList.Add(
                    new Reservation
                    {
                        UserLogin = (Shell.Current as AppShell).UserData.Login,
                        PlaceId = viewModel.Places[8].Id,
                        IsBusy = 1 //Меняем статус места на забронированное
                    });
            }
            else
            {
                ((Frame)sender).BackgroundColor = TempColor;

                var item = viewModel.reservationList.FirstOrDefault(x => x.PlaceId == 9);
                viewModel.reservationList.Remove(item);
            }
        }
        private void OnTapped10(object sender, EventArgs e)
        {

            if (((Frame)sender).BackgroundColor == TempColor)
            {
                ((Frame)sender).BackgroundColor = Color.Yellow;

                viewModel.reservationList.Add(
                    new Reservation
                    {
                        UserLogin = (Shell.Current as AppShell).UserData.Login,
                        PlaceId = viewModel.Places[9].Id,
                        IsBusy = 1 //Меняем статус места на забронированное
                    });
            }
            else
            {
                ((Frame)sender).BackgroundColor = TempColor;

                var item = viewModel.reservationList.FirstOrDefault(x => x.PlaceId == 10);
                viewModel.reservationList.Remove(item);
            }
        }
        private void OnTapped11(object sender, EventArgs e)
        {

            if (((Frame)sender).BackgroundColor == TempColor)
            {
                ((Frame)sender).BackgroundColor = Color.Yellow;

                viewModel.reservationList.Add(
                    new Reservation
                    {
                        UserLogin = (Shell.Current as AppShell).UserData.Login,
                        PlaceId = viewModel.Places[10].Id,
                        IsBusy = 1 //Меняем статус места на забронированное
                    });
            }
            else
            {
                ((Frame)sender).BackgroundColor = TempColor;

                var item = viewModel.reservationList.FirstOrDefault(x => x.PlaceId == 10);
                viewModel.reservationList.Remove(item);
            }
        }
        private void OnTapped12(object sender, EventArgs e)
        {
            if (((Frame)sender).BackgroundColor == TempColor)
            {
                ((Frame)sender).BackgroundColor = Color.Yellow;

                viewModel.reservationList.Add(
                    new Reservation
                    {
                        UserLogin = (Shell.Current as AppShell).UserData.Login,
                        PlaceId = viewModel.Places[11].Id,
                        IsBusy = 1 //Меняем статус места на забронированное
                    });
            }
            else
            {
                ((Frame)sender).BackgroundColor = TempColor;

                var item = viewModel.reservationList.FirstOrDefault(x => x.PlaceId == 10);
                viewModel.reservationList.Remove(item);
            }
        }
        private void OnTapped13(object sender, EventArgs e)
        {
            if (((Frame)sender).BackgroundColor == TempColor)
            {
                ((Frame)sender).BackgroundColor = Color.Yellow;

                viewModel.reservationList.Add(
                    new Reservation
                    {
                        UserLogin = (Shell.Current as AppShell).UserData.Login,
                        PlaceId = viewModel.Places[12].Id,
                        IsBusy = 1 //Меняем статус места на забронированное
                    });
            }
            else
            {
                ((Frame)sender).BackgroundColor = TempColor;

                var item = viewModel.reservationList.FirstOrDefault(x => x.PlaceId == 10);
                viewModel.reservationList.Remove(item);
            }
        }
        private void OnTapped14(object sender, EventArgs e)
        {
            if (((Frame)sender).BackgroundColor == TempColor)
            {
                ((Frame)sender).BackgroundColor = Color.Yellow;

                viewModel.reservationList.Add(
                    new Reservation
                    {
                        UserLogin = (Shell.Current as AppShell).UserData.Login,
                        PlaceId = viewModel.Places[13].Id,
                        IsBusy = 1 //Меняем статус места на забронированное
                    });
            }
            else
            {
                ((Frame)sender).BackgroundColor = TempColor;

                var item = viewModel.reservationList.FirstOrDefault(x => x.PlaceId == 10);
                viewModel.reservationList.Remove(item);
            }
        }
        private void OnTapped15(object sender, EventArgs e)
        {
            if (((Frame)sender).BackgroundColor == TempColor)
            {
                ((Frame)sender).BackgroundColor = Color.Yellow;

                viewModel.reservationList.Add(
                    new Reservation
                    {
                        UserLogin = (Shell.Current as AppShell).UserData.Login,
                        PlaceId = viewModel.Places[14].Id,
                        IsBusy = 1 //Меняем статус места на забронированное
                    });
            }
            else
            {
                ((Frame)sender).BackgroundColor = TempColor;

                var item = viewModel.reservationList.FirstOrDefault(x => x.PlaceId == 10);
                viewModel.reservationList.Remove(item);
            }
        }
        private void OnTapped16(object sender, EventArgs e)
        {
            if (((Frame)sender).BackgroundColor == TempColor)
            {
                ((Frame)sender).BackgroundColor = Color.Yellow;

                viewModel.reservationList.Add(
                    new Reservation
                    {
                        UserLogin = (Shell.Current as AppShell).UserData.Login,
                        PlaceId = viewModel.Places[15].Id,
                        IsBusy = 1 //Меняем статус места на забронированное
                    });
            }
            else
            {
                ((Frame)sender).BackgroundColor = TempColor;

                var item = viewModel.reservationList.FirstOrDefault(x => x.PlaceId == 10);
                viewModel.reservationList.Remove(item);
            }
        }
        private void OnTapped17(object sender, EventArgs e)
        {
            if (((Frame)sender).BackgroundColor == TempColor)
            {
                ((Frame)sender).BackgroundColor = Color.Yellow;

                viewModel.reservationList.Add(
                    new Reservation
                    {
                        UserLogin = (Shell.Current as AppShell).UserData.Login,
                        PlaceId = viewModel.Places[16].Id,
                        IsBusy = 1 //Меняем статус места на забронированное
                    });
            }
            else
            {
                ((Frame)sender).BackgroundColor = TempColor;

                var item = viewModel.reservationList.FirstOrDefault(x => x.PlaceId == 10);
                viewModel.reservationList.Remove(item);
            }
        }
        private void OnTapped18(object sender, EventArgs e)
        {
            if (((Frame)sender).BackgroundColor == TempColor)
            {
                ((Frame)sender).BackgroundColor = Color.Yellow;

                viewModel.reservationList.Add(
                    new Reservation
                    {
                        UserLogin = (Shell.Current as AppShell).UserData.Login,
                        PlaceId = viewModel.Places[17].Id,
                        IsBusy = 1 //Меняем статус места на забронированное
                    });
            }
            else
            {
                ((Frame)sender).BackgroundColor = TempColor;

                var item = viewModel.reservationList.FirstOrDefault(x => x.PlaceId == 10);
                viewModel.reservationList.Remove(item);
            }
        }
        private void OnTapped19(object sender, EventArgs e)
        {
            if (((Frame)sender).BackgroundColor == TempColor)
            {
                ((Frame)sender).BackgroundColor = Color.Yellow;

                viewModel.reservationList.Add(
                    new Reservation
                    {
                        UserLogin = (Shell.Current as AppShell).UserData.Login,
                        PlaceId = viewModel.Places[18].Id,
                        IsBusy = 1 //Меняем статус места на забронированное
                    });
            }
            else
            {
                ((Frame)sender).BackgroundColor = TempColor;

                var item = viewModel.reservationList.FirstOrDefault(x => x.PlaceId == 10);
                viewModel.reservationList.Remove(item);
            }
        }
        private void OnTapped20(object sender, EventArgs e)
        {
            if (((Frame)sender).BackgroundColor == TempColor)
            {
                ((Frame)sender).BackgroundColor = Color.Yellow;

                viewModel.reservationList.Add(
                    new Reservation
                    {
                        UserLogin = (Shell.Current as AppShell).UserData.Login,
                        PlaceId = viewModel.Places[19].Id,
                        IsBusy = 1 //Меняем статус места на забронированное
                    });
            }
            else
            {
                ((Frame)sender).BackgroundColor = TempColor;

                var item = viewModel.reservationList.FirstOrDefault(x => x.PlaceId == 10);
                viewModel.reservationList.Remove(item);
            }
        }
    }
}