using System.ComponentModel.DataAnnotations;
namespace CRUDJokeApp.Models
{
    public class Joke
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [Display(Name = "Joke question")]
        public string JokeQuestion { get; set; }
        [Required]
        public string JokeAnswer { get; set; }
    }
}
