using Microsoft.Extensions.Logging;

namespace DartsScorer.MauiApp;

public static class MauiProgram
{
	public static MauiAppBuilder CreateMauiApp()
	{
		var builder = Microsoft.Maui.Controls.Hosting.MauiApp.CreateBuilder();
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

		return builder.Build();
	}
}
