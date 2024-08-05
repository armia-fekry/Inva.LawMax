using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Inva.LawCases.Lawyers;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Inva.LawCases.Configurations
{
    internal class LawyerConfigurations : IEntityTypeConfiguration<Lawyer>
    {
        public void Configure(EntityTypeBuilder<Lawyer> builder)
        {
            builder.ToTable(nameof(Lawyer));
            builder.ConfigureByConvention();
        }
    }
}
