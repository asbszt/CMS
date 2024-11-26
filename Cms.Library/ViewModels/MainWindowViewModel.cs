using Cms.Library.IServices;

namespace Cms.Library.ViewModels;

public class MainWindowViewModel(IAlertService alertService) : ViewModelBase
{
    private ViewModelBase _content;

    public ViewModelBase Content
    {
        get => _content;
        set => SetProperty(ref _content, value);
    }

    public async Task AlertCommandAsync()
    {
        await alertService.AlertAsync("Info", "Message!");
    }
}