using DTT.CMS.ContentManager.Samples;
using Xunit;

namespace DTT.CMS.ContentManager.EntityFrameworkCore.Applications;

[Collection(ContentManagerTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ContentManagerEntityFrameworkCoreTestModule>
{

}
