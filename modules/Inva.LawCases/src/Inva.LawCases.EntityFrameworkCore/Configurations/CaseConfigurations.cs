using Inva.LawCases.Cases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Inva.LawCases.Configurations
{
    public class CaseConfigurations : IEntityTypeConfiguration<Case>
    {
        public void Configure(EntityTypeBuilder<Case> builder)
        {
            builder.ToTable(nameof(Case));
            builder.ConfigureByConvention();
        }
    }
}
