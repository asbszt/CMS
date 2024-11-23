using System;
using Cms.Library.IServices;
using CustomerManagerSystem.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace CustomerManagerSystem;

public class ServiceLocator
{
    private readonly IServiceProvider _serviceProvider;
    public MainWindowViewModel MainWindowViewModel => _serviceProvider.GetService<MainWindowViewModel>();

    //通过构造函数注册服务，并提交给代理服务
    public ServiceLocator()
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddSingleton<MainWindowViewModel>();
        serviceCollection.AddSingleton<ISystemSettingService, ISystemSettingService>();
        _serviceProvider = serviceCollection.BuildServiceProvider();//注册服务给代理服务
    }
}