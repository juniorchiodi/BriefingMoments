﻿using Microsoft.Extensions.Logging;

namespace BriefingMoments
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
                    fonts.AddFont("BebasNeue-Regular.ttf", "Bebas");
                    fonts.AddFont("VisbyCF-DemiBold.otf", "Visby");
                    fonts.AddFont("VisbyCF-ExtraBold.otf", "VisbyB");


                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
