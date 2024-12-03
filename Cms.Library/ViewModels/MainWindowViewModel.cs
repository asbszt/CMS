using Cms.Library.IServices;
using CommunityToolkit.Mvvm.Input;

namespace Cms.Library.ViewModels;

public class MainWindowViewModel(IAlertService alertService) : ViewModelBase
{
    private ViewModelBase _content;

    private bool _sideMenuExpanded = true;

    public int BorderWidth => _sideMenuExpanded ? 220 : 50;


    public bool SideMenuExpanded
    {
        get => _sideMenuExpanded;
        set
        {
            SetProperty(ref _sideMenuExpanded, value);
            //通知其他属性
            OnPropertyChanged(nameof(BorderWidth));
        }
    }

    public ViewModelBase Content
    {
        get => _content;
        set => SetProperty(ref _content, value);
    }


    public async Task AlertCommandAsync()
    {
        await alertService.AlertAsync("Info", "Message!");
    }

    [RelayCommand]
    public void SideMenuCommand()
    {
        SideMenuExpanded = !_sideMenuExpanded;
    }
}