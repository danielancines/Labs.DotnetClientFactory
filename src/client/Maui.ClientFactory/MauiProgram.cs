using Maui.Connection.Services;
using Maui.Connection.Services.Core;
using Maui.Domain.Contracts;
using Maui.Domain.ViewModels;
using Microsoft.Extensions.Logging;

namespace Maui.ClientFactory
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            builder.Services.AddTransient<MainPage>();
            builder.Services.AddHttpClient<ICustomerService, CustomerService>();
            builder.Services.AddTransient<IMainPageViewModel, MainPageViewModel>();

            return builder.Build();
        }
    }
}