using DTT.CMS.ContentManager.Samples;
using Xunit;

namespace DTT.CMS.ContentManager.EntityFrameworkCore.Domains;

[Collection(ContentManagerTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ContentManagerEntityFrameworkCoreTestModule>
{

}
