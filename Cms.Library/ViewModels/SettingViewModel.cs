using Cms.Library.IServices;

namespace Cms.Library.ViewModels;

public class SettingViewModel(IAlertService alertService) : ViewModelBase
{
    public async Task AlertCommandAsync()
    {
        await alertService.AlertAsync("Info", "Message!");
    }
}