using Cms.Library.IServices;
using Cms.Library.Models;
using Cms.Library.IServices;
namespace Cms.Library.Services;

public class SystemSetting : ISystemSettingService
{
    public Task<List<Models.SystemSetting>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<Models.SystemSetting>> GetAllByNameAsync(string name)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(Models.SystemSetting systemSetting)
    {
        throw new NotImplementedException();
    }
}