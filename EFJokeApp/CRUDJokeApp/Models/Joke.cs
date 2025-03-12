using System.ComponentModel.DataAnnotations;
namespace CRUDJokeApp.Models
{
    public class Joke
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string JokeQuestion { get; set; } = "";
        [Required]
        public string JokeAnswer { get; set; } = "";
    }
}
