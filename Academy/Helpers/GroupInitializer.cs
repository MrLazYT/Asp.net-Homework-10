using Academy.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academy.Helpers
{
    public class GroupInitializer : DbInitializer<Group>
    {
        public static void SeedData(EntityTypeBuilder<Group> builder)
        {
            builder.HasData(new List<Group>
            {
                new Group
                {
                    Id = 1,
                    Name = "GR001",
                    Description = "Programmers Group"
                },
                new Group
                {
                    Id = 2,
                    Name = "GR002",
                    Description = "Designers Group"
                }
            });
        }
    }
}
