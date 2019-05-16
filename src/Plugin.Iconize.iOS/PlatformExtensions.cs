using System;
using System.Text.RegularExpressions;
using CoreGraphics;
using CoreText;
using Foundation;
using Plugin.Iconize.iOS;
using UIKit;

namespace Plugin.Iconize
{
    /// <summary>
    /// Defines the <see cref="PlatformExtensions" /> extensions.
    /// </summary>
    public static class PlatformExtensions
    {
        /// <summary>
        /// To the UI font.
        /// </summary>
        /// <param name="module">The module.</param>
        /// <param name="size">The size.</param>
        /// <returns></returns>
        public static UIFont ToUIFont(this IIconModule module, nfloat size) => UIFont.FromName(module.FontName, size);

        /// <summary>
        /// To the UI image.
        /// </summary>
        /// <param name="icon">The icon.</param>
        /// <param name="size">The size.</param>
        /// <returns></returns>
        public static UIImage ToUIImage(this IIcon icon, nfloat size)
        {
            var attributedString = new NSAttributedString($"{icon.Character}", new CTStringAttributes
            {
                Font = new CTFont(Iconize.FindModuleOf(icon).FontName, size),
                ForegroundColorFromContext = true
            });

            var boundSize = attributedString.GetBoundingRect(new CGSize(10000f, 10000f), NSStringDrawingOptions.UsesLineFragmentOrigin, null).Size;

            UIGraphics.BeginImageContextWithOptions(boundSize, false, 0f);
            attributedString.DrawString(new CGRect(0f, 0f, boundSize.Width, boundSize.Height));
            using (var image = UIGraphics.GetImageFromCurrentImageContext())
            {
                UIGraphics.EndImageContext();

                return image.ImageWithRenderingMode(UIImageRenderingMode.AlwaysTemplate);
            }
        }

        public static NSAttributedString DoParseIcons(this IIconText iconText)
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

            return stringBuilder.Text;
        }
    }
}