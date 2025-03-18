namespace SchoolApp.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty ;
        public ICollection<Class> Class { get; set; }
    }
}
