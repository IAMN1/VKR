using CyberLoungeV2.Models;
using System.Collections.Generic;

namespace CyberLoungeV2.ViewModels
{
    public class SalesViewModel
    {
        public List<Sales> SalesList { get; set; }
        public SalesViewModel()
        {
            SalesList = new List<Sales>
            {
                new Sales{ SalesName = "Приведи друга", SalesDescription = "Приведи друга и получи 100% от его пополнения!", Image = ""},
                new Sales{ SalesName = "Акция Сейф", SalesDescription = "Угадай код от сейфа и удвой сумму пополнения!", Image = ""},
                new Sales{ SalesName = "День рождения", SalesDescription = "Покажи паспорт в день рождения и получи 500 рублей на баланс!", Image = ""},
            };
        }
    }
}
