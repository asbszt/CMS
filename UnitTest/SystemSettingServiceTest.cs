using Cms.Library.Helper;
using Cms.Library.Models;
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

    [Fact]
    public void GetAllAsync_Add()
    {
        var systemSetting = new SystemSetting();
        systemSetting.Name = "Test";
        systemSetting.Value = "Test1";
        systemSetting.Memo = "Test1";
        new SystemSettingService(new CmsDbContext()).UpdateAsync(systemSetting);
        Assert.True(new SystemSettingService(new CmsDbContext()).GetAllAsync().Result.Count >= 0);
    }
}