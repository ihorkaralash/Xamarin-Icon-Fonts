using System.Text.RegularExpressions;
using Android.Content;
using Android.Graphics;
using Android.Runtime;
using Android.Text;
using Android.Util;
using Android.Widget;
using Object = System.Object;

namespace Plugin.IconFonts.Droid
{
    [Register("Plugin.IconFonts.IconButton")]
    public class IconButton : Button, IIconText
    {
        public Color TextColor => new Color(CurrentTextColor);

        public new double TextSize => base.TextSize;

        public virtual ISpannable ParseIcons()
        {
            return this.DoParseIcons();
        }

        public IconButton(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            
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

        public void UpdateText()
        {
            TextChanged -= OnTextChanged;

            var regex = new Regex("{.*?}");
            var text = Text ?? "";

            if (regex.IsMatch(text))
                SetText(ParseIcons(), BufferType.Spannable);

            TextChanged += OnTextChanged;
        }
    }
}