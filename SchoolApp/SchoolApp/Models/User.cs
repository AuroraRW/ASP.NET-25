namespace SchoolApp.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public Student Student { get; set; } = new Student();
    }
}
