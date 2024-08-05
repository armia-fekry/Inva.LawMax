using Inva.LawCases.Hearings;
using Inva.LawCases.Lawyers;
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace Inva.LawCases.Cases
{
    public class Case : Entity<Guid> 
    {
        public int Number { get; set; }
        public int Year { get; set; }
        public string LitigationDegree { get; set; }
        public string FinalVerdict { get; set; }

        public virtual ICollection<Hearing> Hearings { get; set; }
        public virtual ICollection<Lawyer> Lawyers { get; set; }

    }
}
