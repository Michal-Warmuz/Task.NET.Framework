using System.Data.Entity.ModelConfiguration;
using Task.Core.Domain;

namespace Task.Data.Configuration
{
    public class ReservationConfiguration : EntityTypeConfiguration<Reservation>
    {
        public ReservationConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Provision).IsOptional();
            Property(x => x.Source).IsOptional();

            Property(x => x.CheckInDate).IsRequired();
            Property(x => x.CheckOutDate).IsRequired();
            Property(x => x.Code).IsRequired().HasMaxLength(10);
            Property(x => x.CreatedAt).IsRequired();
            Property(x => x.Currency).IsRequired();
            Property(x => x.Price).IsRequired();
        }
    }
}
