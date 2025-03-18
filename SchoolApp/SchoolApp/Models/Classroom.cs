namespace SchoolApp.Models
{
    public class Classroom
    {
        public int ClassroomId { get; set; }
        public string RoomNumber { get; set; } = string.Empty;
        public string Capacity { get; set; } = string.Empty;
        public string RoomType {  get; set; } = string.Empty;
        public ICollection<Class> Class { get; set; }
    }
}
