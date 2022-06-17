using System.ComponentModel.DataAnnotations;

namespace ServerForAppV1.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        [Required]
        public string UserLogin { get; set; }
        public int PlaceId { get; set; }
        public int IsBusy { get; set; }
    }
}
