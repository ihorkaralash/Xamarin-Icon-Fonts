using System;
using Android.App;
using Android.Runtime;
using Plugin.IconFonts.Fonts;

namespace IconFonts.Sample.Droid
{
    [Application]
    public class MainApplication : Application
    {
        public MainApplication(IntPtr handle, JniHandleOwnership transer)
            : base(handle, transer)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();

            Plugin.IconFonts.IconFonts.With(new FontAwesomeBrandsModule())
                .With(new FontAwesomeRegularModule())
                .With(new FontAwesomeSolidModule());
        }
    }
}