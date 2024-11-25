using Cms.Library.Models;

namespace Cms.Library.IServices;

public interface ISystemSettingService
{
    Task<List<SystemSetting>> GetAllAsync();
    Task<List<SystemSetting>> GetAllByNameAsync(string name);
    Task UpdateAsync(SystemSetting systemSetting);
}