using AutoMapper;
using DTT.CMS.ContentManager.CMSContents;

namespace DTT.CMS.ContentManager;

public class ContentManagerApplicationAutoMapperProfile : Profile
{
    public ContentManagerApplicationAutoMapperProfile()
    {
        CreateMap<CMSContent, CMSContentDto>();
        CreateMap<CreateUpdateCMSContentDto, CMSContent>();
        CreateMap<CMSContent , CreateUpdateCMSContentDto>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
