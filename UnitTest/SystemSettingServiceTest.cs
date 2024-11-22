using Cms.Library.Helper;
using Cms.Library.Services;

namespace UnitTest;

public class SystemSettingServiceTest
{
    [Fact]
    public void GetAllAsync_Sucess()
    {
        Assert.True(new SystemSettingService(new CmsDbContext()).GetAllAsync().Result.Count >= 0);
    }
}