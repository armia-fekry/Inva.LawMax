using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Inva.LawCases.Lawyers
{
    public interface ILawyerAppService : 
        ICrudAppService<LawyerGetDto,Guid,PagedAndSortedResultRequestDto,lawyerCreateDto>
    {

    }
}
