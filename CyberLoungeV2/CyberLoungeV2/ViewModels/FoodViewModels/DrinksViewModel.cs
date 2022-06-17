using CyberLoungeV2.Models.FoodModels;
using System.Collections.Generic;

namespace CyberLoungeV2.ViewModels.FoodViewModels
{
    public class DrinksViewModel
    {
        public List<Drink> DrinkList { get; set; }
        public DrinksViewModel()
        {
            DrinkList = new List<Drink>
            {
                new Drink { ProductName = "Coca-cola",Price = "100Р",ProductDescription = "0.5л",  ProductImage = "Cola.png" },
                new Drink { ProductName = "Bonaqua", Price = "120Р", ProductDescription = "0.5л" ,ProductImage = "Bonaqua.png" },
                new Drink { ProductName = "Pepsi", Price = "150Р", ProductDescription = "0.5л" ,ProductImage = "Pepsi.png" }
            };
        }
    }
}
