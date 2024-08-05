using Inva.LawCases.Configurations;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Inva.LawCases.EntityFrameworkCore;

public static class LawCasesDbContextModelCreatingExtensions
{
    public static void ConfigureLawCases(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        // Add Entities Configurations
        builder.ApplyConfiguration(new CaseConfigurations());
        builder.ApplyConfiguration(new LawyerConfigurations());
        builder.ApplyConfiguration(new HearingConfigurations());

        /* Configure all entities here. Example:
        
        builder.Entity<Question>(b =>
        {
            //Configure table & schema name
            b.ToTable(LawCasesDbProperties.DbTablePrefix + "Questions", LawCasesDbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

            //Relations
            b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            b.HasIndex(q => q.CreationTime);
        });
        */
    }
}
