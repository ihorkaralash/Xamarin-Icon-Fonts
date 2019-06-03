
using Foundation;

namespace Plugin.IconFonts.iOS
{
    public class IconStringBuilder : NSMutableAttributedString
    {
        private readonly IIconText _iconText;

        public IconStringBuilder(IIconText iconText)
        {
            _iconText = iconText;
        }

        public NSAttributedString Text = new NSAttributedString();

        public void AppendText(string text)
        {
            var attrStr = new NSAttributedString(text, _iconText.Font, _iconText.TextColor);

            Append(attrStr);
        }

        public void AppendIcon(IIcon icon)
        {
            var font = IconFonts.FindModuleOf(icon)?.ToUIFont(_iconText.Font.PointSize);
            var attrStr = new NSAttributedString($"{icon.Character}", font, _iconText.TextColor);

            Append(attrStr);
        }

        public override void Append(NSAttributedString attrString)
        {
            var str = new NSMutableAttributedString();
            str.Append(Text);
            str.Append(attrString);

            Text = str;
        }
    }
}