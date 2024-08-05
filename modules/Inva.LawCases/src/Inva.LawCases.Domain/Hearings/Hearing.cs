using Inva.LawCases.Cases;
using System;
using Volo.Abp.Domain.Entities;

namespace Inva.LawCases.Hearings
{
    public class Hearing : Entity<Guid>
    {
        public DateTime Date { get; set; }
        public string Decision { get; set; }

        public Guid CaseId { get; set; }
        public virtual Case Case { get; set; }
    }
}
