namespace GradeContainer.Models
{
    public class Evaluation
    {
        public int Id { get; set; }
        public int Grade { get; set; }
        public int Worth { get; set; }
        public required Course Course { get; set; }
        public int CourseId { get; set; }

    }
}
