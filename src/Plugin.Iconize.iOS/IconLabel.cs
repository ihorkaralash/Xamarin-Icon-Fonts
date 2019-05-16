using System.Text.RegularExpressions;
using Foundation;
using UIKit;

namespace Plugin.Iconize.iOS
{
    public class IconLabel : UILabel, IIconText
    {
        public NSAttributedString ParseIcons()
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