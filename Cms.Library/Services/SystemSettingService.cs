using Cms.Library.Helper;
using Cms.Library.IServices;
using Cms.Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Cms.Library.Services;

public class SystemSettingService(CmsDbContext context) : ISystemSettingService
{
    public async Task<List<SystemSetting>> GetAllAsync()
    {
        return await context.SystemSetting.ToListAsync();
    }

    public async Task<List<SystemSetting>> GetAllByNameAsync(string name)
    {
        return await context.SystemSetting.Where(s => s.Name == name).ToListAsync();
    }

    public async Task UpdateAsync(SystemSetting systemSetting)
    {
        context.SystemSetting.Update(systemSetting);
        await context.SaveChangesAsync();
    }
}