using Cms.Library.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Cms.Library.IServices;

public interface ISystemSettingService
{
    Task<List<SystemSetting>> GetAllAsync();
    Task<List<SystemSetting>> GetAllByNameAsync(string name);
    EntityEntry<SystemSetting> UpdateAsync(SystemSetting systemSetting);
}