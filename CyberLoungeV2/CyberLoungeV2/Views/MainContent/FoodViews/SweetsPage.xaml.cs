using CyberLoungeV2.Models.FoodModels;
using CyberLoungeV2.ViewModels.FoodViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CyberLoungeV2.Views.MainContent.Food
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SweetsPage : ContentPage
    {
        SweetsViewModel viewModel;
        public SweetsPage()
        {
            viewModel = new SweetsViewModel();
            InitializeComponent();
            SweetsList.BindingContext = viewModel;
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            // Получаем выбранный элемент 
            Sweets selectedItem = args.SelectedItem as Sweets;
            if (selectedItem != null)
            {
                // Снимаем выделение
                SweetsList.SelectedItem = null;
            }
        }
    }
}