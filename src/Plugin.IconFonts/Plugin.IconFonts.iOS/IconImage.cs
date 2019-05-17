using System;
using System.ComponentModel;
using Foundation;
using UIKit;

namespace Plugin.IconFonts
{
    [Register("IconImage")]
    [DesignTimeVisible(true)]
    public class IconImage : UIImageView, IComponent
    {
        public ISite Site { get; set; }
        public event EventHandler Disposed;

        private String _icon;
        private UIColor _iconColor;
        private nfloat _iconSize;

        [Export("Icon"), Browsable(true)]
        public String Icon
        {
            get => _icon;
            set
            {
                _icon = value;
                UpdateImage(true);
            }
        }

        [Export("IconColor"), Browsable(true)]
        public UIColor IconColor
        {
            get => _iconColor;
            set
            {
                _iconColor = value;
                UpdateImage(false);
            }
        }

        [Export("IconSize"), Browsable(true)]
        public nfloat IconSize
        {
            get => _iconSize;
            set
            {
                _iconSize = value;
                UpdateImage(true);
            }
        }

        public IconImage(IntPtr handle): base(handle)
        {

        }

        public IconImage()
        {

        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();

            UpdateImage(true);
        }

        public void UpdateImage(Boolean shouldUpdateImage)
        {
            if (shouldUpdateImage)
            {
                ContentMode = IconSize > 0 ? UIViewContentMode.Center : UIViewContentMode.ScaleAspectFit;

                var icon = IconFonts.FindIconForKey(Icon);
                if (icon is null)
                {
                    Image = null;
                    return;
                }

                var iconSize = IconSize > 0 ? IconSize : Math.Max(Bounds.Width, Bounds.Height);

                using (var image = icon.ToUIImage((nfloat)iconSize))
                {
                    Image = image;
                }
            }

            TintColor = IconColor;
        }
    }
}