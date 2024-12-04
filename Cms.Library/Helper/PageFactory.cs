using Cms.Library.ViewModels;

namespace Cms.Library.Helper;

/// <summary>
///     提供 ViewModel的工厂类
/// </summary>
public class PageFactory
{
    private readonly Func<PageNames, PageModelBase> _factory;

    public PageFactory(Func<PageNames, PageModelBase> factory)
    {
        _factory = factory;
    }

    public PageModelBase CreatePageViewModel(PageNames name)
    {
        return _factory.Invoke(name);
    }
}