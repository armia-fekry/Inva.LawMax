using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Inva.LawCases.Lawyers
{
    public class LawyersAppService :
        CrudAppService<
            Lawyer,
            LawyerGetDto,
            Guid, 
            PagedAndSortedResultRequestDto,
            lawyerCreateDto>, 
        ILawyerAppService
    {
        public LawyersAppService(IRepository<Lawyer , Guid> repository) : base(repository)
        {
            
        }
    }
}
