using Cms.Library.Helper;
using Cms.Library.IServices;

namespace Cms.Library.ViewModels;

public class SettingViewModel : PageModelBase
{
    private readonly IAlertService _alertService;

    public SettingViewModel(IAlertService alertService)
    {
        PageName = PageNames.Settings;
        _alertService = alertService;
    }

    public async Task AlertCommandAsync()
    {
        await _alertService.AlertAsync("Info", "Message!");
    }
}