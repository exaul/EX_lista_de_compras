using ExamenParcial2.Services;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace ExamenParcial2;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif
        builder.Services.AddSingleton<Views.LoginPage>();
        builder.Services.AddSingleton<Views.PreguntasPage>();
        
        builder.Services.AddSingleton<ViewModels.LoginPageViewModel>();
        builder.Services.AddSingleton<ViewModels.PreguntasViewModel>();

        builder.Services.AddSingleton<Services.Interfaces.ILoginService, LoginService>();
        builder.Services.AddSingleton<Services.Interfaces.IPreguntasService, PreguntasService>();

        return builder.Build();
    }
}