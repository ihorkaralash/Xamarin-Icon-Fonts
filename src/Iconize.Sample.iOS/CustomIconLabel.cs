using System;
using Foundation;
using Plugin.Iconize.iOS;
using UIKit;

namespace Iconize.Sample.iOS
{
    [Register("CustomIconLabel")]
    public class CustomIconLabel : IconLabel
    {
        public UIColor IconColor { get; set; }

        public CustomIconLabel(IntPtr handle) : base(handle)
        {

        }

        public CustomIconLabel()
        {

        }

        public override NSAttributedString ParseIcons()
        {
            var text = (NSMutableAttributedString)base.ParseIcons();

            text.AddAttributes(new UIStringAttributes { ForegroundColor = IconColor }, new NSRange(0, 1));

            return text;
        }
    }
}
