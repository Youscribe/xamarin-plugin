using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;

namespace MATTest
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to
    // application events from iOS.
    [Register ("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        // class-level declarations
        UIWindow window;
        MATTestViewController viewController;
        //
        // This method is invoked when the application has loaded and is ready to run. In this
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching (UIApplication app, NSDictionary options)
        {
            window = new UIWindow (UIScreen.MainScreen.Bounds);
            
            viewController = new MATTestViewController ();
            window.RootViewController = viewController;
            window.MakeKeyAndVisible ();
            
            return true;
        }

        public override bool OpenUrl (UIApplication application, NSUrl url, string sourceApplication, NSObject annotation)
        {
            Console.WriteLine ("AppDelegate.OpenUrl: url = " + url + ", sourceApplication = " + sourceApplication);

            return true;
        }
    }
}

