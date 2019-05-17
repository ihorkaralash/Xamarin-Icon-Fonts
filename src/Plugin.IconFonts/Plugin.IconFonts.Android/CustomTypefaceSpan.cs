using Android.Graphics;
using Android.Text;
using Android.Text.Style;

namespace Plugin.IconFonts
{
    public class CustomTypefaceSpan : MetricAffectingSpan
    {
        private readonly Typeface _typeface;

        public CustomTypefaceSpan(Typeface typeface)
        {
            _typeface = typeface;
        }

        public override void UpdateDrawState(TextPaint tp)
        {
            tp.SetTypeface(_typeface);
        }

        public override void UpdateMeasureState(TextPaint p)
        {
            p.SetTypeface(_typeface);
        }
    }
}