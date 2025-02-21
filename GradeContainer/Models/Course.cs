namespace GradeContainer.Models
{
    public class Course
    {
        public int Id { get; set; }
        public int? CourseCode { get; set; }
        public required string CourseName {get; set;}

        public ICollection<Evaluation> Evaluations { get; } = new List<Evaluation>();
    }
}
