using Foundation;

namespace SharepointListTools.BlazorMaui;

[Register("AppDelegate")]
#pragma warning disable CA1711 // Identifiers should not have incorrect suffix
public class AppDelegate : MauiUIApplicationDelegate
#pragma warning restore CA1711 // Identifiers should not have incorrect suffix
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
