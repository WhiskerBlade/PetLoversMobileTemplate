using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Compatibility.Hosting;
using PetLovers.ViewModels.Auth;
using PetLovers.ViewModels.Home;
using PetLovers.ViewModels.Startup;
using PetLovers.Views;
using PetLovers.Controls;
using PetLovers.Views.Auth;
using PetLovers.Views.Home;
using PetLovers.Views.Home.Views;
using PetLovers.Views.Startup;
using Sharpnado.Tabs;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace PetLovers
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseSkiaSharp()
                .UseMauiCompatibility()
                .UseMauiCommunityToolkit()
                .UseSharpnadoTabs(loggerEnable: false)
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");

                    fonts.AddFont("Poppins-Black.ttf", "Poppins-Black");
                    fonts.AddFont("Poppins-BlackItalic.ttf", "PoppinsBlackItalic");
                    fonts.AddFont("Poppins-Bold.ttf", "PoppinsBold");
                    fonts.AddFont("Poppins-BoldItalic.ttf", "PoppinsBoldItalic");
                    fonts.AddFont("Poppins-ExtraBold.ttf", "PoppinsExtraBold");
                    fonts.AddFont("Poppins-ExtraBoldItalic.ttf", "PoppinsExtraBoldItalic");
                    fonts.AddFont("Poppins-ExtraLight.ttf", "PoppinsExtraLight");
                    fonts.AddFont("Poppins-ExtraLightItalic.ttf", "PoppinsExtraLightItalic");
                    fonts.AddFont("Poppins-Italic.ttf", "PoppinsItalic");
                    fonts.AddFont("Poppins-Light.ttf", "PoppinsLight");
                    fonts.AddFont("Poppins-LightItalic.ttf", "PoppinsLightItalic");
                    fonts.AddFont("Poppins-Medium.ttf", "PoppinsMedium");
                    fonts.AddFont("Poppins-MediumItalic.ttf", "PoppinsMediumItalic");
                    fonts.AddFont("Poppins-Regular.ttf", "PoppinsRegular");
                    fonts.AddFont("Poppins-SemiBold.ttf", "PoppinsSemiBold");
                    fonts.AddFont("Poppins-SemiBoldItalic.ttf", "PoppinsSemiBoldItalic");
                    fonts.AddFont("Poppins-Thin.ttf", "PoppinsThin");
                    fonts.AddFont("Poppins-ThinItalic.ttf", "PoppinsThinItalic");

                    fonts.AddFont("MaterialIcons-Regular.ttf", "MaterialIcons");
                })
                            .ConfigureMauiHandlers((handlers) => {

#if ANDROID
                                handlers.AddCompatibilityRenderer(typeof(CameraPreview), typeof(PetLovers.Platforms.Android.CameraPreviewRenderer));
#endif

                            });

            #region View Models
            builder.Services.AddSingleton<LoadingPageViewModel>();
            builder.Services.AddSingleton<LoginPageViewModel>();
            builder.Services.AddSingleton<RegisterPageViewModel>();
            builder.Services.AddSingleton<PasswordRecoveryPageViewModel>();

            builder.Services.AddSingleton<BottomTabsPageViewModel>();
            builder.Services.AddSingleton<HomePageViewModel>();
            builder.Services.AddSingleton<MyProfilePageViewModel>();
            #endregion


            #region Pages
            builder.Services.AddSingleton<LoadingPage>();
            builder.Services.AddSingleton<LoginPage>();
            builder.Services.AddSingleton<RegisterPage>();
            builder.Services.AddSingleton<PasswordRecoveryPage>();

            builder.Services.AddSingleton<IndexPage>();


            builder.Services.AddSingleton<HomePage>();
            builder.Services.AddSingleton<ChatPage>();
            builder.Services.AddSingleton<NotificationsPage>();
            builder.Services.AddSingleton<MyProfilePage>();
            #endregion



#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
