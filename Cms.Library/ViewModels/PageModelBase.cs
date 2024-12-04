using Cms.Library.Helper;

namespace Cms.Library.ViewModels;

public class PageModelBase : ViewModelBase
{
    private PageNames _pageName;

    public PageNames PageName
    {
        get => _pageName;
        set => SetProperty(ref _pageName, value);
    }
}