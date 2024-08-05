using Inva.LawCases.Cases;
using System;
using System.Collections.Generic;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace Inva.LawCases.Lawyers
{
    public class Lawyer : Entity<Guid>
    {
        public Lawyer(string name , string position , string mobile , string address)
        {
            Check.NotNull(name, "name","Name Is Required");
            Check.NotNull(position, "Position", "Position Is Required");
            // Complete Validation as business needs

            Name = name;
            Position = position;
            Mobile = mobile;
            Address = address;
           
        }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Case> Cases { get; set; }
    }
}
