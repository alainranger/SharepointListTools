using ObjCRuntime;
using UIKit;

namespace SharepointListTools.BlazorMaui;

#pragma warning disable S1118 // Utility classes should not have public constructors
public class Program
#pragma warning restore S1118 // Utility classes should not have public constructors
{
	// This is the main entry point of the application.
	static void Main(string[] args)
	{
		// if you want to use a different Application Delegate class from "AppDelegate"
		// you can specify it here.
		UIApplication.Main(args, null, typeof(AppDelegate));
	}
}
