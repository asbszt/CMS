using Cms.Library.Helper;
using Cms.Library.IServices;

namespace Cms.Library.ViewModels;

public class HomeViewModel : PageModelBase
{
    private readonly IAlertService _alertService;

    public HomeViewModel(IAlertService alertService)
    {
        PageName = PageNames.Home;
        _alertService = alertService;
    }

    public void AlertCommand()
    {
        _alertService.AlertAsync("Home Page", "Tite");
    }
}