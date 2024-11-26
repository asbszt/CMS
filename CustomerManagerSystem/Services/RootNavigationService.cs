using Cms.Library.IServices;

namespace CustomerManagerSystem.Services;

public class RootNavigationService:IRootNavigationService
{
    public void NavigateTo(string view)
    {
        //ServiceLocator.Current.MainWindowViewModel.Content = view;
        throw new System.NotImplementedException();
    }
}