using CommunityToolkit.Mvvm.Input;

namespace Cms.Library.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ViewModelBase _content;
    private bool _sideMenuExpanded = true;

    public bool SideMenuExpanded
    {
        get => _sideMenuExpanded;
        set => SetProperty(ref _sideMenuExpanded, value);
    }

    public ViewModelBase Content
    {
        get => _content;
        set => SetProperty(ref _content, value);
    }


    public async Task AlertCommandAsync()
    {
        // await alertService.AlertAsync("Info", "Message!");
    }

    [RelayCommand]
    public void SideMenuCommand()
    {
        SideMenuExpanded = !_sideMenuExpanded;
    }
}