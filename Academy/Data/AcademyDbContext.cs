using Academy.Helpers;
using Academy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academy.Data
{
    public class AcademyContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }

        public AcademyContext() { }

        public AcademyContext(DbContextOptions<AcademyContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            EntityTypeBuilder<Student> studentBuilder = modelBuilder.Entity<Student>();
            EntityTypeBuilder<Group> groupBuilder = modelBuilder.Entity<Group>();

            StudentsInitializer.SeedData(studentBuilder);
            GroupInitializer.SeedData(groupBuilder);
        }

        public Student GetStudentById(int id)
        {
            return Students.FirstOrDefault(student => student.Id == id)!;
        }

        public List<Student> GetStudentList()
        {
            return Students.ToList();
        }

        public List<Group> GetGroupList()
        {
            return Groups.ToList();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
            SaveChanges();
        }

        public void UpdateStudent(Student student)
        {
            Students.Update(student);
            SaveChanges();
        }

        public void RemoveStudent(Student student)
        {
            Students.Remove(student);
            SaveChanges();
        }
    }
}
