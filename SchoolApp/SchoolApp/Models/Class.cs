namespace SchoolApp.Models
{
    public class Class
    {
        public int ClassId { get; set; }
        public Teacher Teacher { get; set; } = new Teacher();
        public Subject Subject { get; set; } = new Subject();
        public Classroom Classroom { get; set; } = new Classroom();
        public ICollection<Student> Student { get; set; }
    }
}
