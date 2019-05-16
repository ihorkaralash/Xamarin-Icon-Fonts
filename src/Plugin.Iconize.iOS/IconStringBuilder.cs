﻿
using Foundation;

namespace Plugin.Iconize.iOS
{
    public class IconStringBuilder : NSMutableAttributedString
    {
        private readonly IIconText _iconText;

        public IconStringBuilder(IIconText iconText)
        {
            _iconText = iconText;
        }

        public void AppendText(string text)
        {
            var attrStr = new NSAttributedString(text, _iconText.Font, _iconText.TextColor);

            Append(attrStr);
        }

        public void AppendIcon(IIcon icon)
        {
            var font = Iconize.FindModuleOf(icon)?.ToUIFont(_iconText.Font.PointSize);
            var attrStr = new NSAttributedString($"{icon.Character}", font, _iconText.TextColor);

            Append(attrStr);
        }
    }
}