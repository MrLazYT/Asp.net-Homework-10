using Academy.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academy.Helpers
{
    public class StudentsInitializer : DbInitializer<Student>
    {
        public static void SeedData(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(new List<Student>()
            {
                new Student
                {
                    Id = 1,
                    FirstName = "Denys",
                    LastName = "Gladan",
                    Age = 21,
                    GroupId = 1
                },
                new Student
                {
                    Id = 2,
                    FirstName = "Petro",
                    LastName = "Sahaidachnyi",
                    Age = 30,
                    GroupId = 2
                },
                new Student
                {
                    Id = 3,
                    FirstName = "Semen",
                    LastName = "Kos",
                    Age = 18,
                    GroupId = 1
                },
                new Student
                {
                    Id = 4,
                    FirstName = "Yurii",
                    LastName = "Herych",
                    Age = 28,
                    GroupId = 1
                },
                new Student
                {
                    Id = 5,
                    FirstName = "Yurii",
                    LastName = "Korniichuk",
                    Age = 15,
                    GroupId = 1
                },
                new Student
                {
                    Id = 6,
                    FirstName = "Symon",
                    LastName = "Petliura",
                    Age = 37,
                    GroupId = 2
                },
                new Student
                {
                    Id = 7,
                    FirstName = "Kostiantyn",
                    LastName = "Palii",
                    Age = 24,
                    GroupId = 1
                },
                new Student
                {
                    Id = 8,
                    FirstName = "Ivan",
                    LastName = "Didenko",
                    Age = 21,
                    GroupId = 2
                },
                new Student
                {
                    Id = 9,
                    FirstName = "Petro",
                    LastName = "Ostapchenko",
                    Age = 17,
                    GroupId = 2
                },
                new Student
                {
                    Id = 10,
                    FirstName = "Maxym",
                    LastName = "Ukraiinec",
                    Age = 18,
                    GroupId = 2
                },
            });
        }
    }
}
