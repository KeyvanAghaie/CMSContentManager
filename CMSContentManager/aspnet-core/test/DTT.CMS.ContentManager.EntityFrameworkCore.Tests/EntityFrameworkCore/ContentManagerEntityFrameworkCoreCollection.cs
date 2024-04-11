using Xunit;

namespace DTT.CMS.ContentManager.EntityFrameworkCore;

[CollectionDefinition(ContentManagerTestConsts.CollectionDefinitionName)]
public class ContentManagerEntityFrameworkCoreCollection : ICollectionFixture<ContentManagerEntityFrameworkCoreFixture>
{

}
