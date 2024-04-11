using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;

namespace DTT.CMS.ContentManager.CMSContents.Contracts
{
    public interface ICMSContentAppService : IApplicationService, ITransientDependency
    {
        Task<PagedResultDto<CMSContentDto>> GetAll(CancellationToken cancellationToken);
        Task<CreateUpdateCMSContentDto> InsertOrUpdateCMSContent(CreateUpdateCMSContentDto input, CancellationToken cancellationToken);
        Task<CMSContentDto> GetCMSContent(Guid id, CancellationToken cancellationToken);
    }
}
