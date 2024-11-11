using Microsoft.Extensions.Logging;

namespace MauiAppHotel
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

                    fonts.AddFont("Lexend-Black.ttf", "LexendBlack");
                    fonts.AddFont("Lexend-Bold.ttf", "LexendBold");
                    fonts.AddFont("Lexend-ExtraBold.ttf", "LexendExtraBold");
                    fonts.AddFont("Lexend-ExtraLight.ttf", "LexendExtraLight");
                    fonts.AddFont("Lexend-Light.ttf", "LexendLight");
                    fonts.AddFont("Lexend-Medium.ttf", "LexendMedium");
                    fonts.AddFont("Lexend-Regular.ttf", "Lexend");
                    fonts.AddFont("Lexend-SemiBold.ttf", "LexendSemiBold");
                    fonts.AddFont("Lexend-Thin.ttf", "LexendThin");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
