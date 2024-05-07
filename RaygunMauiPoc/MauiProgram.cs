using Microsoft.Extensions.Logging;
using Raygun4Maui;

namespace RaygunMauiPoc;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.AddRaygun(options =>
			{
				options.RaygunSettings.ApiKey = "<<Your_API_Key_Goes_Here>>";
				options.RaygunSettings.CatchUnhandledExceptions = true;
			})
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

