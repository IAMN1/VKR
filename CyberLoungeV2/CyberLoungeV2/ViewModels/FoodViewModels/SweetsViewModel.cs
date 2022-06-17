using CyberLoungeV2.Models.FoodModels;
using System.Collections.Generic;

namespace CyberLoungeV2.ViewModels.FoodViewModels
{
    public class SweetsViewModel
    {
        public List<Sweets> SweetsList { get; set; }
        public SweetsViewModel()
        {
            SweetsList = new List<Sweets>
            {
                new Sweets { ProductName = "KitKat",Price = "100Р",ProductDescription = "50 г.",  ProductImage = "Kitkat.png" },
                new Sweets { ProductName = "Snickers", Price = "120Р", ProductDescription = "70 г." ,ProductImage = "snikers.png" },
                new Sweets { ProductName = "Twix", Price = "150Р", ProductDescription = "60 г." ,ProductImage = "twix.png" },
                new Sweets { ProductName = "MilkyWay", Price = "80Р", ProductDescription = "55 г." ,ProductImage = "MilkyWay.png" }
            };
        }
    }
}
