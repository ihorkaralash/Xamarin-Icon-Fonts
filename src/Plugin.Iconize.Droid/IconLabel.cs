using System;
using System.Text.RegularExpressions;
using Android.Content;
using Android.Graphics;
using Android.Runtime;
using Android.Text;
using Android.Text.Style;
using Android.Util;
using Android.Widget;

namespace Plugin.Iconize.Droid
{
    [Register("Plugin.Iconize.IconLabel")]
    public class IconLabel : TextView
    {
        private readonly Typeface _typeface;

        private Color _iconsColor;
        private Double _iconsSize;

        public Color IconsColor
        {
            get => _iconsColor;
            set
            {
                _iconsColor = value;
                UpdateText();
            }
        }

        public Double IconsSize
        {
            get => _iconsSize;
            set
            {
                _iconsSize = value;
                UpdateText();
            }
        }

        public IconLabel(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            _typeface = Typeface;
        }

        protected override void OnAttachedToWindow()
        {
            base.OnAttachedToWindow();

            TextChanged += OnTextChanged;
        }

        protected override void OnDetachedFromWindow()
        {
            TextChanged -= OnTextChanged;

            base.OnDetachedFromWindow();
        }

        protected override void OnSizeChanged(int w, int h, int oldw, int oldh)
        {
            base.OnSizeChanged(w, h, oldw, oldh);

            SetAllCaps(false);

            UpdateText();
        }

        private void OnTextChanged(Object sender, TextChangedEventArgs e)
        {
            UpdateText();
        }

        private void StyleAsText(ISpannable spannable, int start, int end)
        {
            spannable.SetSpan(new CustomTypefaceSpan(_typeface), start, end, SpanTypes.ExclusiveInclusive);
            spannable.SetSpan(new ForegroundColorSpan(new Color(CurrentTextColor)), start, end, SpanTypes.ExclusiveInclusive);
            spannable.SetSpan(new AbsoluteSizeSpan((int)TextSize), start, end, SpanTypes.ExclusiveInclusive);
        }

        private void StyleAsIcon(ISpannable spannable, IIcon icon, int start, int end)
        {
            spannable.SetSpan(new CustomTypefaceSpan(Iconize.FindModuleOf(icon).ToTypeface(Context)), start, end, SpanTypes.ExclusiveInclusive);
            spannable.SetSpan(new ForegroundColorSpan(IconsColor), start, end, SpanTypes.ExclusiveInclusive);
            spannable.SetSpan(new AbsoluteSizeSpan((int)IconsSize), start, end, SpanTypes.ExclusiveInclusive);
        }

        private void UpdateText()
        {
            TextChanged -= OnTextChanged;

            var regex = new Regex("{.*?}");
            var text = Text ?? "";
            var stringBuilder = new SpannableStringBuilder();
            var firstIconGroupEntry = text.IndexOf("{", StringComparison.InvariantCulture);

            if (firstIconGroupEntry != -1)
            {
                stringBuilder.Append(text.Substring(0, firstIconGroupEntry));
                StyleAsText(stringBuilder, 0, firstIconGroupEntry);
            }

            foreach (Match match in regex.Matches(text))
            {
                var icon = Iconize.FindIconForKey(match.Value.Replace("{", "").Replace("}", ""));
                if (icon != null)
                {
                    stringBuilder.Append(icon.Character);
                    StyleAsIcon(stringBuilder, icon, stringBuilder.Length() - 1, stringBuilder.Length());
                }
                else
                {
                    stringBuilder.Append(match.Value);
                    StyleAsText(stringBuilder, stringBuilder.Length() - match.Value.Length, stringBuilder.Length());
                }

                var nextMatch = match.NextMatch();
                if (!string.IsNullOrEmpty(nextMatch.Value))
                {
                    var textToNextIcon = text.Substring(match.Index + match.Length, nextMatch.Index - match.Index - match.Length);

                    stringBuilder.Append(textToNextIcon);
                    StyleAsText(stringBuilder, stringBuilder.Length() - textToNextIcon.Length, stringBuilder.Length());
                }
                else
                {
                    var textToEndOfLine = text.Substring(match.Index + match.Length, text.Length - match.Index - match.Length);

                    stringBuilder.Append(textToEndOfLine);
                    StyleAsText(stringBuilder, stringBuilder.Length() - textToEndOfLine.Length, stringBuilder.Length());
                }
            }

            if (regex.IsMatch(text))
                SetText(stringBuilder, BufferType.Spannable);

            var i = Iconize.FindIconForKey(text);
            if (!(i is null))
            {
                Text = $"{i.Character}";
                Typeface = Iconize.FindModuleOf(i).ToTypeface(Context);
            }

            TextChanged += OnTextChanged;
        }
    }
}