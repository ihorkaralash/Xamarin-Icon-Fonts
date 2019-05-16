using Android.App;
using Android.Text;
using Android.Text.Style;

namespace Plugin.Iconize.Droid
{
    public class IconStringBuilder : SpannableStringBuilder
    {
        private readonly IIconText _iconText;

        public IconStringBuilder(IIconText iconText)
        {
            _iconText = iconText;
        }

        public void AppendIcon(IIcon icon)
        {
            Append(icon.Character);

            SetSpan(new CustomTypefaceSpan(Iconize.FindModuleOf(icon).ToTypeface(Application.Context)), Length() - 1, Length(), SpanTypes.ExclusiveInclusive);
            SetSpan(new ForegroundColorSpan(_iconText.TextColor), Length() - 1, Length(), SpanTypes.ExclusiveInclusive);
            SetSpan(new AbsoluteSizeSpan((int)_iconText.TextSize), Length() - 1, Length(), SpanTypes.ExclusiveInclusive);
        }

        public void AppendText(string text)
        {
            Append(text);

            SetSpan(new CustomTypefaceSpan(_iconText.Typeface), Length() - text.Length, Length(), SpanTypes.ExclusiveInclusive);
            SetSpan(new ForegroundColorSpan(_iconText.TextColor), Length() - text.Length, Length(), SpanTypes.ExclusiveInclusive);
            SetSpan(new AbsoluteSizeSpan((int) _iconText.TextSize), Length() - text.Length, Length(), SpanTypes.ExclusiveInclusive);
        }
    }
}