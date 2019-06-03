using System;
using Android.Content;
using Android.Graphics;
using Android.Runtime;
using Android.Util;
using Android.Widget;

namespace Plugin.IconFonts.Droid
{
    [Register("Plugin.IconFonts.IconImage")]
    public class IconImage : ImageView
    {
        private String _icon;
        private Color _iconColor;
        private Double _iconSize;

        public String Icon
        {
            get => _icon;
            set
            {
                _icon = value;
                UpdateImage();
            }
        }

        public Color IconColor
        {
            get => _iconColor;
            set
            {
                _iconColor = value;
                UpdateImage();
            }
        }

        public Double IconSize
        {
            get => _iconSize;
            set
            {
                _iconSize = value;
                UpdateImage();
            }
        }

        public IconImage(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            var ta = context.ObtainStyledAttributes(attrs, Resource.Styleable.IconImage);

            _icon = ta.GetString(Resource.Styleable.IconImage_Icon);
            _iconColor = ta.GetColor(Resource.Styleable.IconImage_IconColor, Color.Black);
            _iconSize = ta.GetFloat(Resource.Styleable.IconImage_IconSize, 0);
        }

        protected override void OnSizeChanged(int w, int h, int oldw, int oldh)
        {
            base.OnSizeChanged(w, h, oldw, oldh);

            UpdateImage();
        }

        public void UpdateImage()
        {
            var icon = IconFonts.FindIconForKey(Icon);
            if (icon is null)
            {
                SetImageResource(Android.Resource.Color.Transparent);
                return;
            }

            var iconSize = IconSize > 0 ? IconSize : Math.Max(Width, Height)/Resources.DisplayMetrics.Density;

            var drawable = new IconDrawable(Context, icon).Color(IconColor).SizeDp((Int32)iconSize);
            SetScaleType(IconSize > 0 ? ScaleType.Center : ScaleType.FitCenter);
            SetImageDrawable(drawable);
        }
    }
}