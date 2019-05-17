using Foundation;
using UIKit;

namespace Plugin.IconFonts
{
    public interface IIconText
    {
        UIFont Font { get; }

        UIColor TextColor { get; }

        string Text { get; }

        NSAttributedString ParseIcons();
    }
}