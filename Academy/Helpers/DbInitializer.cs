using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academy.Helpers
{
    public abstract class DbInitializer<T> where T : class
    {
        public static void SeedData(EntityTypeBuilder<T> builder) { }
    }
}
