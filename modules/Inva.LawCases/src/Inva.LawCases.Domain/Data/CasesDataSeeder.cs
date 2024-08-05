using Inva.LawCases.Cases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.Domain.Repositories;

namespace Inva.LawCases.Data
{
    public class CasesDataSeeder //: IDataSeedContributor
    {
        private readonly IRepository<Case, Guid> _casesRepository;

        public CasesDataSeeder(IRepository<Case,Guid> CasesRepository)
        {
            _casesRepository=CasesRepository;
        }
        
    }
}
