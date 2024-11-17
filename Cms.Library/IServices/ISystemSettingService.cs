using Cms.Library.Models;

namespace Cms.Library.IServices;

public partial interface ISystemSettingService
{
    Task<List<SystemSetting>> GetAllAsync();
    Task<List<SystemSetting>> GetAllByNameAsync(string name);
    Task AddAsync(SystemSetting systemSetting);
    
}