using Inva.LawCases.Lawyers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Inva.LawCases.Data
{
    public class LawyersDataSeeder : IDataSeedContributor , ITransientDependency
    {
        private readonly IRepository<Lawyer, Guid> _lawyerRepository;

        
        public LawyersDataSeeder(IRepository<Lawyer , Guid> lawyerRepository)
        {
            this._lawyerRepository=lawyerRepository;
        }
        public async Task SeedAsync(DataSeedContext context)
        {
            var lawyers = new List<Lawyer>()
            {
                new  Lawyer("Armia Fekry Zaki" , "Manger" , "120120120" , "Address one"),
                new  Lawyer("Fekry Zaki Fekry" , "Junior Lawyer" , "120120120" , "Address one"),
                new  Lawyer("Zaki Armia Fekry" , "Director" , "120120120" , "Address one")
            };

            await _lawyerRepository.InsertManyAsync(lawyers);
        }
    }
}
