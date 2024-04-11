using DTT.CMS.ContentManager.CMSContents;
using DTT.CMS.ContentManager.CMSContents.Contracts;
using Shouldly;
using System.Collections.Generic;
using System.Threading;
using System;
using System.Threading.Tasks;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Xunit;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

namespace DTT.CMS.ContentManager.Samples;

/* This is just an example test class.
 * Normally, you don't test code of the modules you are using
 * (like IIdentityUserAppService here).
 * Only test your own application services.
 */
public abstract class CMSContentAppServiceTests<TStartupModule> : ContentManagerApplicationTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{
    private readonly ICMSContentAppService _cMSContentAppService;
    protected CMSContentAppServiceTests()
    {
        _cMSContentAppService = GetRequiredService<ICMSContentAppService>();
    }

    [Fact]
    public async Task GetAll_Should_Return_All_Contents()
    {
        // Arrange
        var expectedContents = new List<CMSContent>
        {
            new CMSContent { Title = "Test Title 1", Content = "Test Content 1" },
            new CMSContent { Title = "Test Title 2", Content = "Test Content 2" }
        };

        // Act
        var result = await _cMSContentAppService.GetAll(CancellationToken.None);

        // Assert
        Assert.Equal(expectedContents.Count, result.TotalCount);
        Assert.Equal(expectedContents.Count, result.Items.Count);
    }


    [Fact]
    public async Task InsertOrUpdateCMSContent_Should_Insert_New_Content()
    {
        // Arrange
        var input = new CreateUpdateCMSContentDto { Title = "Test Title", Content = "Test Content" };
        var expectedContent = new CMSContent { Title = input.Title, Content = input.Content };

        // Act
        var result = await _cMSContentAppService.InsertOrUpdateCMSContent(input, CancellationToken.None);

        // Assert
        Assert.Equal(input.Title, result.Title);
        Assert.Equal(input.Content, result.Content);
    }


    [Fact]
    public async Task GetCMSContent_Should_Return_Correct_Content()
    {
        // Arrange
        var expectedContent = new CMSContent { Title = "Test Title", Content = "Test Content" };
        var expectedDto = new CMSContentDto { Title = expectedContent.Title, Content = expectedContent.Content };

        // Act
        var result = await _cMSContentAppService.GetCMSContent(expectedContent.Id, CancellationToken.None);

        // Assert
        Assert.Equal(expectedDto.Title, result.Title);
        Assert.Equal(expectedDto.Content, result.Content);
    }


}
