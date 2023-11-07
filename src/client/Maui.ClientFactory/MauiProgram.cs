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

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddHttpClient<ICustomerService, CustomerService>(client =>
            {
                client.BaseAddress = new Uri("http://localhost:5053");
            });

            builder.Services.AddTransient<IMainPageViewModel, MainPageViewModel>();

            return builder.Build();
        }
    }
}