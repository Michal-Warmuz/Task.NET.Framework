using System.Data.Entity.ModelConfiguration;
using Task.Core.Domain;

namespace Task.Data.Configuration
{
    public class GuestConfiguration : EntityTypeConfiguration<Guest>
    {
        public GuestConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.ZIP).IsOptional();
            Property(x => x.DateOfBirth).IsOptional();
            Property(x => x.Phone).IsOptional();
            Property(x => x.City).IsOptional();
            Property(x => x.Address).IsOptional();

            Property(x => x.Email).IsRequired();
            Property(x => x.FirstName).IsRequired();
            Property(x => x.LastName).IsRequired();
        }
    }
}
