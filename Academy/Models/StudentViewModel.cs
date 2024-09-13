namespace Academy.Models
{
    public class StudentViewModel
    {
        public Student Student { get; set; }
        public List<Group> Groups { get; set; }

        public StudentViewModel()
        {
            Student = new Student();
        }
    }
}
