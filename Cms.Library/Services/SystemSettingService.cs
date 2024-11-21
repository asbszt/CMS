using Cms.Library.Helper;
using Cms.Library.IServices;
using Cms.Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Cms.Library.Services;

public class SystemSettingService : ISystemSettingService
{
    private readonly CmsDbContext _context;

    public SystemSettingService(CmsDbContext context)
    {
        _context = context;
    }

    public async Task<List<SystemSetting>> GetAllAsync()
    {
        return await _context.SystemSettings.ToListAsync();
    }

    public async Task<List<SystemSetting>> GetAllByNameAsync(string name)
    {
        return await _context.SystemSettings.Where(s => s.Name == name).ToListAsync();
    }

    public void UpdateAsync(SystemSetting systemSetting)
    {
        _context.SystemSettings.Update(systemSetting);
    }
}