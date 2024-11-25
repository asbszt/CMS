using System;
using Avalonia;
using Cms.Library.IServices;
using Cms.Library.Services;
using Cms.Library.ViewModels;
using CustomerManagerSystem.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CustomerManagerSystem;

public class ServiceLocator
{
    public static ServiceLocator _current;
    private readonly IServiceProvider _serviceProvider;

    //通过构造函数注册服务，并提交给代理服务
    public ServiceLocator()
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddSingleton<MainWindowViewModel>();
        serviceCollection.AddSingleton<ISystemSettingService, SystemSettingService>();
        serviceCollection.AddSingleton<IAlertService, AlertService>();
        _serviceProvider = serviceCollection.BuildServiceProvider(); //注册服务给代理服务
    }

    /// <summary>
    /// 提供业务端使用ServiceLocator
    /// </summary>
    /// <exception cref="NullReferenceException"></exception>
    public static ServiceLocator Current
    {
        get
        {
            if (_current is not null) return _current;

            if (Application.Current.TryGetResource(nameof(ServiceLocator), null, out var resource) &&
                resource is ServiceLocator serviceLocator)
                return _current = serviceLocator;
            throw new NullReferenceException();
        }
    }

    public MainWindowViewModel MainWindowViewModel => _serviceProvider.GetService<MainWindowViewModel>();
}