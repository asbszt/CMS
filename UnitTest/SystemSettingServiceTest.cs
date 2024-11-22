using Cms.Library.Helper;
using Cms.Library.Services;

namespace UnitTest;

public class SystemSettingServiceTest : IDisposable
{
    public void Dispose()
    {
        throw new NotImplementedException();
    }

    [Fact]
    public void GetAllAsync_Sucess()
    {
        Assert.True(new SystemSettingService(new CmsDbContext()).GetAllAsync().Result.Count >= 0);
    }
}