using Android.Content;
using Android.Graphics;
using Android.Runtime;
using Android.Text;
using Android.Text.Style;
using Android.Util;
using Plugin.Iconize.Droid;

namespace Iconize.Sample.Droid
{
    [Register("Plugin.Iconize.CustomIconButton")]
    public class CustomIconButton : IconButton
    {
        public CustomIconButton(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

        public override ISpannable ParseIcons()
        {
            var text = base.ParseIcons();

            text.SetSpan(new ForegroundColorSpan(Color.Red), 0, 1, SpanTypes.ExclusiveInclusive);
            text.SetSpan(new AbsoluteSizeSpan(30), 0, 1, SpanTypes.ExclusiveInclusive);

            return text;
        }
    }
}