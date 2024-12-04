using Cms.Library.IServices;

namespace Cms.Library.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private readonly IAlertService _alertService;
    private readonly HomeViewModel _homeViewModel;
    private readonly InitializationViewModel _initializationViewModel;
    private readonly IRootNavigationService _rootNavigationService;
    private readonly SettingViewModel _settingViewModel;
    private ViewModelBase _currentPage;
    private string _homeButtonClasses;


    private bool _sideMenuExpanded = true;


    public MainWindowViewModel(IAlertService alertService, IRootNavigationService rootNavigationService,
        SettingViewModel settingViewModel, InitializationViewModel initializationViewModel, HomeViewModel homeViewModel)
    {
        _alertService = alertService;
        _rootNavigationService = rootNavigationService;
        _settingViewModel = settingViewModel;
        _initializationViewModel = initializationViewModel;
        _homeViewModel = homeViewModel;
        _currentPage = _homeViewModel;
    }

    public bool HomePageActive => CurrentPage == _homeViewModel;
    public bool BasePageActive => CurrentPage == _initializationViewModel;

    public int BorderWidth => _sideMenuExpanded ? 220 : 85;

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

    public ViewModelBase CurrentPage
    {
        get => _currentPage;
        set
        {
            SetProperty(ref _currentPage, value);
            OnPropertyChanged(nameof(HomePageActive));
            OnPropertyChanged(nameof(BasePageActive));
        }
    }


    public async Task AlertCommandAsync()
    {
        await _alertService.AlertAsync("Info", "Message!");
    }


    public void SideMenuCommand()
    {
        SideMenuExpanded = !_sideMenuExpanded;
    }

    public void SettingCommand()
    {
        CurrentPage = _settingViewModel;
    }

    public void HomeCommand()
    {
        CurrentPage = _homeViewModel;
    }

    public void BaseCommand()
    {
        CurrentPage = _initializationViewModel;
    }
}