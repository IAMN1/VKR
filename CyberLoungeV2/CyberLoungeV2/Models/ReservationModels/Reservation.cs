namespace CyberLoungeV2.Models.ReservationModels
{
    //Модель для отправки данных о бронировании на сервер
    public class Reservation
    {
        public int Id { get; set; }
        public string UserLogin { get; set; }
        public int PlaceId { get; set; }
        public int IsBusy { get; set; }
    }
}
