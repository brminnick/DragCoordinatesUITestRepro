using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace DragCoordinatesUITestRepro.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

#if DEBUG
            Xamarin.Calabash.Start();
#endif

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
