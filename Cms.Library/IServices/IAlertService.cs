namespace Cms.Library.IServices;

/// <summary>
///     提示、错误、警告弹窗服务
/// </summary>
public interface IAlertService
{
    Task AlertAsync(string title, string message);
}