namespace Plugin.IconFonts.Fonts
{
    /// <summary>
    /// Defines the <see cref="JamIconsModule" /> icon module.
    /// </summary>
    /// <seealso cref="Plugin.IconFonts.IconModule" />
    public sealed class JamIconsModule : IconModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JamIconsModule" /> class.
        /// </summary>
        public JamIconsModule()
            : base("Jam-icons", "Jam-icons", "iconfonts-jam-icons.ttf", JamIconsCollection.Icons)
        {
            // Intentionally left blank
        }
    }
}