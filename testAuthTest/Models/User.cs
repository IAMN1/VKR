
using System.ComponentModel.DataAnnotations;

namespace ServerForAppV1.Models
{
    public class User
    {
        public int Id { get; set; }
       
        //Аннотация Required говорит о том, 
        // что эти поля не могут быть пустыми
        [Required]
        public string Login { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Deposit { get; set; } = "123";
    }
}
