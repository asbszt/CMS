using Cms.Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Cms.Library.Helper;

public class CmsDbContext:DbContext
{
    public DbSet<CustomerRetailFlow> CustomerRetailFlows { get; set; }
    public DbSet<CustomerInfo> CustomerInfos { get; set; }
    public DbSet<CustomerRetailMaster> CustomerRetailMasters { get; set; }
    public DbSet<SystemSetting> SystemSettings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       // optionsBuilder.UseMySql("Data Source=localhost;Port=3306;User Id=root;Password=123456;",);
    }
}