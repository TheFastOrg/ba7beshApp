﻿using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using bahbashApp.Views;
using bahbashApp.Services.Navigation;
using bahbashApp.Services.Settings;
using bahbashApp.Services.Authentication;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace bahbashApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .UseSkiaSharp()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont(filename: "materialdesignicons-webfont.ttf", alias: "MaterialDesignIcons");
            })
            .RegisterAppServices()
            .RegisterPages();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}


    private static MauiAppBuilder RegisterAppServices(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<INavigationService, NavigationService>();
        mauiAppBuilder.Services.AddSingleton<ISettingsService, SettingsService>();
        mauiAppBuilder.Services.AddSingleton<IAuthenticationService, AuthenticationService>();
        return mauiAppBuilder;
    }

    private static MauiAppBuilder RegisterPages(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddTransient<AppShell>();
        mauiAppBuilder.Services.AddTransientWithShellRoute<SignInView, LoginViewModel>("login");
        mauiAppBuilder.Services.AddTransientWithShellRoute<ProfileView, ProfileViewModel>("profile");
        mauiAppBuilder.Services.AddTransientWithShellRoute<WelcomeView, WelcomeViewModel>("welcome");
        return mauiAppBuilder;
    }
}
