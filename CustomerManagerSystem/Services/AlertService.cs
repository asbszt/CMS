using System.Threading.Tasks;
using Cms.Library.IServices;
using Ursa.Controls;

namespace CustomerManagerSystem.Services;

public class AlertService : IAlertService
{
    public async Task AlertAsync(string title, string message)
    {
        await MessageBox.ShowAsync(message, title, button: MessageBoxButton.OK);
    }
}