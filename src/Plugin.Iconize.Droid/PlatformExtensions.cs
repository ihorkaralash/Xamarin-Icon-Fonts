using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Text;
using Plugin.Iconize.Droid;

namespace Plugin.Iconize
{
    /// <summary>
    /// Defines the <see cref="PlatformExtensions" /> extensions.
    /// </summary>
    public static class PlatformExtensions
    {
        private static readonly Dictionary<Type, Typeface> _fontCache = new Dictionary<Type, Typeface>();

        /// <summary>
        /// To the bitmap.
        /// </summary>
        /// <param name="drawable">The drawable.</param>
        /// <returns></returns>
        public static Bitmap ToBitmap(this Drawable drawable)
        {
            Bitmap bitmap = null;

            if (drawable is BitmapDrawable bitmapDrawable && bitmapDrawable.Bitmap != null)
            {
                return bitmapDrawable.Bitmap;
            }

            if (drawable.IntrinsicWidth <= 0 || drawable.IntrinsicHeight <= 0)
            {
                bitmap = Bitmap.CreateBitmap(1, 1, Bitmap.Config.Argb8888); // Single color bitmap will be created of 1x1 pixel
            }
            else
            {
                bitmap = Bitmap.CreateBitmap(drawable.IntrinsicWidth, drawable.IntrinsicHeight, Bitmap.Config.Argb8888);
            }

            var canvas = new Canvas(bitmap);
            drawable.SetBounds(0, 0, canvas.Width, canvas.Height);
            drawable.Draw(canvas);
            return bitmap;
        }

        public static ISpannable DoParseIcons(this IIconText iconText)
        {
            var regex = new Regex("{.*?}");
            var text = iconText.Text ?? "";
            var stringBuilder = new IconStringBuilder(iconText);
            var firstIconGroupEntry = text.IndexOf("{", StringComparison.InvariantCulture);

            if (firstIconGroupEntry != -1)
            {
                stringBuilder.AppendText(text.Substring(0, firstIconGroupEntry));
            }

            foreach (Match match in regex.Matches(text))
            {
                var icon = Iconize.FindIconForKey(match.Value.Replace("{", "").Replace("}", ""));
                if (icon != null)
                {
                    stringBuilder.AppendIcon(icon);
                }
                else
                {
                    stringBuilder.AppendText("?");
                }

                var nextMatch = match.NextMatch();
                if (!string.IsNullOrEmpty(nextMatch.Value))
                {
                    var textToNextIcon = text.Substring(match.Index + match.Length, nextMatch.Index - match.Index - match.Length);

                    stringBuilder.AppendText(textToNextIcon);
                }
                else
                {
                    var textToEndOfLine = text.Substring(match.Index + match.Length, text.Length - match.Index - match.Length);

                    stringBuilder.AppendText(textToEndOfLine);
                }
            }

            return stringBuilder;
        }

        /// <summary>
        /// To the typeface.
        /// </summary>
        /// <param name="module">The module.</param>
        /// <param name="context">The context.</param>
        /// <returns></returns>
        public static Typeface ToTypeface(this IIconModule module, Context context)
        {
            var moduleType = module.GetType();
            if (!_fontCache.ContainsKey(moduleType))
            {
                _fontCache.Add(moduleType, Typeface.CreateFromAsset(Application.Context.Assets, module.FontPath));
            }
            return _fontCache[moduleType];
        }
    }
}