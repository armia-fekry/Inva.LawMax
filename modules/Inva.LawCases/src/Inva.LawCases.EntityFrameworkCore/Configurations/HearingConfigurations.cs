using Inva.LawCases.Hearings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Inva.LawCases.Configurations
{
    public class HearingConfigurations : IEntityTypeConfiguration<Hearing>
    {
        public void Configure(EntityTypeBuilder<Hearing> builder)
        {
            builder.ToTable(nameof(Hearing));
            builder.ConfigureByConvention();
        }
    }
}
