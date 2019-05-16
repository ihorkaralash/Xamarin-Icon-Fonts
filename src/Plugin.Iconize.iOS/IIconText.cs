using Foundation;
using UIKit;

namespace Plugin.Iconize.iOS
{
    public interface IIconText
    {
        UIFont Font { get; }

        UIColor TextColor { get; }

        string Text { get; }

        NSAttributedString ParseIcons();
    }
}