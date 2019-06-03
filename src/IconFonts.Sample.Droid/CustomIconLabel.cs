using Android.Content;
using Android.Graphics;
using Android.Runtime;
using Android.Text;
using Android.Text.Style;
using Android.Util;
using Plugin.IconFonts.Droid;

namespace IconFonts.Sample.Droid
{
    [Register("Plugin.IconFonts.CustomIconLabel")]
    public class CustomIconLabel : IconLabel
    {
        public Color IconColor { get; set; }

        public CustomIconLabel(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            IconColor = TextColor;
        }

        public override ISpannable ParseIcons()
        {
            var text = base.ParseIcons();

            text.SetSpan(new ForegroundColorSpan(IconColor), 0, 1, SpanTypes.ExclusiveInclusive);

            return text;
        }
    }
}