using System.Threading.Tasks;
using Inva.LawCases.Lawyers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace Inva.LawCases.Samples;

[Area(LawCasesRemoteServiceConsts.ModuleName)]
[RemoteService(Name = LawCasesRemoteServiceConsts.RemoteServiceName)]
[Route("api/LawCases/Law")]
public class LawController : LawCasesController
{
    private readonly ILawyerAppService _lawyerAppService;

    public LawController(ILawyerAppService lawyerAppService)
    {
        _lawyerAppService = lawyerAppService;
    }

    [HttpGet]
    [Authorize]
    public async Task<PagedResultDto<LawyerGetDto>> GetAllAsync()
    {
        return await _lawyerAppService
            .GetListAsync(new PagedAndSortedResultRequestDto());
    }

    
}
