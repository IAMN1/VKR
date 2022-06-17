using CyberLoungeV2.ViewModels.NewsViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CyberLoungeV2.Views.MainContent
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsPage : ContentPage
    {
        NewsViewModel _viewModel;
        
        public NewsPage()
        {
            // Для передачи параметров в другие страницы
            _viewModel = new NewsViewModel { Navigation = Navigation };
            
            InitializeComponent();

            //Вывод депозита пользователя
            Depositlbl.Text = (Shell.Current as AppShell).UserData.Deposit + "Р";

            if (Depositlbl.Text == "0Р")
            {
                Depositlbl.TextColor = Color.Red;
            }
            else
            {
                Depositlbl.TextColor = Color.Green;
            }
            BindingContext = _viewModel;
        }

        private void ClickedProfileCommand(object sender, EventArgs e)
        {
            _viewModel.ClickedOnProfile();
        }
    }
}