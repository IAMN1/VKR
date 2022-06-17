using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CyberLoungeV2.ViewModels.FoodViewModels;
using CyberLoungeV2.Models.FoodModels;

namespace CyberLoungeV2.Views.MainContent.Food
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DrinksPage : ContentPage
    {
        DrinksViewModel viewModel;
        public DrinksPage()
        {
            viewModel = new DrinksViewModel();
            InitializeComponent();
            DrinkList.BindingContext = viewModel;
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            // Получаем выбранный элемент 
             Drink selectedItem = args.SelectedItem as Drink;
            if (selectedItem != null)
            {
                // Снимаем выделение
                DrinkList.SelectedItem = null;
            }
        }
    }
}