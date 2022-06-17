using CyberLoungeV2.Models.FoodModels;
using System.Collections.Generic;

namespace CyberLoungeV2.ViewModels.FoodViewModels
{
    public class SnacksViewModel
    {
        public List<Snacks> SnacksList { get; set; }

        public SnacksViewModel()
        {
            SnacksList = new List<Snacks>
            {
                new Snacks { ProductName = "Чипсы Lays",Price = "100Р",ProductDescription = "100 г.",  ProductImage = "Lays.png" },
                new Snacks { ProductName = "Чипсы Pringles", Price = "120Р", ProductDescription = "150 г." ,ProductImage = "Pringles.png" },
                new Snacks { ProductName = "Чипсы Cheetos", Price = "150Р", ProductDescription = "120 г." ,ProductImage = "Cheetos.png" }
            };
        }
    }
}
