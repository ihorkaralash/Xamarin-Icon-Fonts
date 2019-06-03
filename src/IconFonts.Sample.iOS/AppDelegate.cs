using Foundation;
using Plugin.IconFonts.Fonts;
using UIKit;

namespace IconFonts.Sample.iOS
{
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        public override UIWindow Window { get; set; }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            Plugin.IconFonts.IconFonts.With(new FontAwesomeBrandsModule())
                .With(new FontAwesomeRegularModule())
                .With(new FontAwesomeSolidModule());

            return true;
        }
    }
}

