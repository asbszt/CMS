using System.Threading.Tasks;
using Cms.Library.IServices;

namespace CustomerManagerSystem.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private readonly IAlertService _alertService;

    public MainWindowViewModel(IAlertService alertService)
    {
        _alertService = alertService;
    }

    public async Task AlertCommandAsync()
    {
        await _alertService.AlertAsync("Info", "Message!");
    }
}