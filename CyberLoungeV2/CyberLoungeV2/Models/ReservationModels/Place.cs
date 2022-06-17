namespace CyberLoungeV2.Models.ReservationModels
{
    //Модель для отображения данных о местах в клубе
    public class Place
    {
        public int Id { get; set; }
        public string NumberPlace { get; set; }
        public int IsBusy { get; set; }
    }
}
