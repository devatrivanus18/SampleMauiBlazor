﻿using SampleMauiBlazor.Data;
using SampleMauiBlazor.Services;
using SampleMauiBlazor.ViewModels;
using Syncfusion.Blazor;

namespace SampleMauiBlazor;

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
			});
		builder.Services.AddDevExpressServerSideBlazorReportViewer();
		builder.Services.AddDevExpressBlazor(configure => configure.BootstrapVersion = DevExpress.Blazor.BootstrapVersion.v5);
		builder.Services.AddDevExpressBlazor();
		builder.Services.AddDevExpressServerSideBlazorReportViewer();
		builder.Services.AddMauiBlazorWebView();
        builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = true; });
        builder.Services.AddScoped<IPrintingService, PrintingService>();
#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
#endif

		builder.Services.AddSingleton<WeatherForecastService>();
		builder.Services.AddSingleton<NorthwindService>();
		return builder.Build();

	}
}
