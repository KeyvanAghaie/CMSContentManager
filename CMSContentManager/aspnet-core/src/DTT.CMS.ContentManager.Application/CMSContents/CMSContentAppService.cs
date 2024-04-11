using DTT.CMS.ContentManager.CMSContents.Contracts;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Application.Dtos;

namespace DTT.CMS.ContentManager.CMSContents
{
    public class CMSContentAppService : ICMSContentAppService //implement the ICMSContentAppService
    {
        private readonly IRepository<CMSContent, Guid> _contentRepository;
        private readonly Volo.Abp.ObjectMapping.IObjectMapper _objectMapper;

        public CMSContentAppService(
            IRepository<CMSContent, Guid> contentRepository,
            Volo.Abp.ObjectMapping.IObjectMapper objectMapper)
        {
            _contentRepository = contentRepository;
            _objectMapper = objectMapper;
        }

        public async Task<PagedResultDto<CMSContentDto>> GetAll(CancellationToken cancellationToken)
        {
            var contents = await _contentRepository.GetListAsync(cancellationToken: cancellationToken);
            return new PagedResultDto<CMSContentDto>(
            contents.Count,
            _objectMapper.Map<List<CMSContent>, List<CMSContentDto>>(contents)
            );
        }

        public async Task<CMSContentDto> GetCMSContent(Guid id, CancellationToken cancellationToken)
        {
            var content = await _contentRepository.GetAsync(id ,cancellationToken: cancellationToken);
            return _objectMapper.Map<CMSContent, CMSContentDto>(content);
        }

        public async Task<CreateUpdateCMSContentDto> InsertOrUpdateCMSContent(CreateUpdateCMSContentDto input, CancellationToken cancellationToken)
        {
            var cMSContent = new CMSContent();
            if (input.Id is null)
                cMSContent = await _contentRepository.InsertAsync(new CMSContent() { Content = input.Content, Title = input.Title }, autoSave: true);
            else
                cMSContent = await _contentRepository.UpdateAsync(new CMSContent() { Content = input.Content, Title = input.Title });
            return _objectMapper.Map<CMSContent, CreateUpdateCMSContentDto>(cMSContent);
        }
    }
}
