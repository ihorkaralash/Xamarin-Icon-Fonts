using System;
using System.Text.RegularExpressions;
using Foundation;
using UIKit;

namespace Plugin.IconFonts
{
    [Register("IconLabel")]
    public class IconLabel : UILabel, IIconText
    {
        public IconLabel(IntPtr handle) : base(handle)
        {

        }

        public IconLabel()
        {

        }

        public virtual NSAttributedString ParseIcons()
        {
            return this.DoParseIcons();
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();

            UpdateText();
        }

        public void UpdateText()
        {
            var regex = new Regex("{.*?}");
            var text = Text ?? "";

            if (regex.IsMatch(text))
                AttributedText = ParseIcons();
        }
    }
}