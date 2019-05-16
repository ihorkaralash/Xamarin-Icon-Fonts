using System.Text.RegularExpressions;
using Foundation;
using UIKit;

namespace Plugin.Iconize.iOS
{
    public class IconButton : UIButton, IIconText
    {
        public UIColor TextColor => TitleColor(UIControlState.Normal);

        public string Text => CurrentTitle;

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
            var text = CurrentTitle ?? "";

            if (regex.IsMatch(text))
                SetAttributedTitle(ParseIcons(), UIControlState.Normal);
        }
    }
}