using Cms.Library.IServices;
using Cms.Library.Models;

namespace Cms.Library.Services;

public class SystemSettingService : ISystemSettingService
{
    public Task<List<SystemSetting>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<SystemSetting>> GetAllByNameAsync(string name)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(SystemSetting systemSetting)
    {
        throw new NotImplementedException();
    }
}