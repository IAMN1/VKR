using CyberLoungeV2.Models.FoodModels;
using CyberLoungeV2.ViewModels.FoodViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CyberLoungeV2.Views.MainContent.Food
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SnaksPage : ContentPage
    {
        SnacksViewModel viewModel;
        public SnaksPage()
        {
            viewModel = new SnacksViewModel();
            InitializeComponent();
            SnacksList.BindingContext = viewModel;
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            // Получаем выбранный элемент 
            Snacks selectedItem = args.SelectedItem as Snacks;
            if (selectedItem != null)
            {
                // Снимаем выделение
                SnacksList.SelectedItem = null;
            }
        }
    }
}