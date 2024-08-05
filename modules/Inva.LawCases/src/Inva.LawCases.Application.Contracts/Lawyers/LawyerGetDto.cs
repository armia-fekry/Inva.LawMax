using System;
using Volo.Abp.Domain.Entities.Events.Distributed;

namespace Inva.LawCases.Lawyers
{
    public class LawyerGetDto : EntityEto<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
    }
}
