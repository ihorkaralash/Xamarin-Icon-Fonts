namespace Plugin.IconFonts.Fonts
{
    /// <summary>
    /// Defines the <see cref="SimpleLineIconsModule" /> icon module.
    /// </summary>
    /// <seealso cref="Plugin.IconFonts.IconModule" />
    public sealed class SimpleLineIconsModule : IconModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleLineIconsModule" /> class.
        /// </summary>
        public SimpleLineIconsModule()
            : base("simple-line-icons", "simple-line-icons", "iconfonts-simplelineicons.ttf", SimpleLineIconsCollection.Icons)
        {
            // Intentionally left blank
        }
    }
}