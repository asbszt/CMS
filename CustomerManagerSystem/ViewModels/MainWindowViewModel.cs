using Cms.Library.IServices;

namespace CustomerManagerSystem.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private readonly IAlertService _alertService;

    public MainWindowViewModel(IAlertService alertService)
    {
        _alertService = alertService;
    }

    public void Alert()
    {
        _alertService.AlertAsync("Info", "Message!");
    }
}