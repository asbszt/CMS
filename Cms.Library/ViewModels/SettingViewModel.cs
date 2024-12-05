using Cms.Library.Helper;
using Cms.Library.IServices;

namespace Cms.Library.ViewModels;

public class SettingViewModel : PageModelBase
{
    private readonly IAlertService _alertService;
    private List<string> _defaultPath;

    public SettingViewModel(IAlertService alertService)
    {
        PageName = PageNames.Settings;
        _alertService = alertService;
        DefaultPath = new List<string>
        {
            @"c:\tmp\Cms\Data\Defalut",
            @"c:\tmp\Cms\Data\Defalut",
            @"c:\tmp\Cms\Data\Defalut",
            @"c:\tmp\Cms\Data\Defalut"
        };
    }

    public List<string> DefaultPath
    {
        get => _defaultPath;
        set => SetProperty(ref _defaultPath, value);
    }

    public async Task AlertCommandAsync()
    {
        await _alertService.AlertAsync("Info", "Message!");
    }
}