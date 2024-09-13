namespace Academy.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public ICollection<Student> Students { get; set; }

        public Group()
        {
            Students = new HashSet<Student>();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
