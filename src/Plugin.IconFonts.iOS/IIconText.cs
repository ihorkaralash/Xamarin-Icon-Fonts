using Foundation;
using UIKit;

namespace Plugin.IconFonts.iOS
{
    public interface IIconText
    {
        UIFont Font { get; }

        UIColor TextColor { get; }

        string Text { get; }

        NSAttributedString ParseIcons();
    }
}