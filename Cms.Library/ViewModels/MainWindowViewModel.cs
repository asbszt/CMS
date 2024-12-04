using Cms.Library.Helper;
using Cms.Library.IServices;

namespace Cms.Library.ViewModels;

public class MainWindowViewModel : PageModelBase
{
    private readonly IAlertService _alertService;
    private readonly PageFactory _pageFactory;
    private PageModelBase _currentPage;
    private bool _sideMenuExpanded = true;


    public MainWindowViewModel(PageFactory pageFactory, IAlertService alertService)
    {
        _pageFactory = pageFactory;
        _alertService = alertService;
        HomeCommand();
    }

    public bool HomePageActive => CurrentPage.PageName == PageNames.Home;
    public bool BasePageActive => CurrentPage.PageName == PageNames.Initialization;

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

    public PageModelBase CurrentPage
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
        CurrentPage = _pageFactory.CreatePageViewModel(PageNames.Settings);
    }

    public void HomeCommand()
    {
        CurrentPage = _pageFactory.CreatePageViewModel(PageNames.Home);
    }

    public void BaseCommand()
    {
        CurrentPage = _pageFactory.CreatePageViewModel(PageNames.Initialization);
    }
}