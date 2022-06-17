using CyberLoungeV2.Models;
using CyberLoungeV2.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CyberLoungeV2.Views.MainContent.NewsViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SalesPage : ContentPage
    {
        SalesViewModel viewModel;
        public SalesPage()
        {
            viewModel = new SalesViewModel();
            InitializeComponent();
            salesList.BindingContext = viewModel;
        }
        private void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            // Получаем выбранный элемент 
            Sales selectedItem = args.SelectedItem as Sales;
            if (selectedItem != null)
            {
                // Снимаем выделение
                salesList.SelectedItem = null;
            }
        }
    }
}