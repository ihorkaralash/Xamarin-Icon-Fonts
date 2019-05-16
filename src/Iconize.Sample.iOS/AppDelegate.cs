using Foundation;
using Plugin.Iconize.Fonts;
using UIKit;

namespace Iconize.Sample.iOS
{
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        public override UIWindow Window { get; set; }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            Plugin.Iconize.Iconize.With(new FontAwesomeBrandsModule())
                .With(new FontAwesomeRegularModule())
                .With(new FontAwesomeSolidModule());

            return true;
        }
    }
}

