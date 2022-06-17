namespace ServerForAppV1.Models
{
    public class Place
    {
        public int Id { get; set; }
        public string NumberPlace { get; set; }

        // 0 - свободен, 1 - забронирован, -1 - занят 
        public int IsBusy { get; set; } = 0;
    }
}
