using Cms.Library.Helper;
using Cms.Library.Services;

namespace UnitTest;

public class SystemSettingServiceTest : IDisposable
{
    //通过构造函数清理资源
    

    //通过垃圾回收调用释放来清理资源
    public void Dispose()
    {

    }

    [Fact]
    public void GetAllAsync_Sucess()
    {
        Assert.True(new SystemSettingService(new CmsDbContext()).GetAllAsync().Result.Count >= 0);
    }
}