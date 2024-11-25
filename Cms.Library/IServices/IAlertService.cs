namespace Cms.Library.IServices;

public interface IAlertService
{
    Task AlertAsync(string title, string message);
}