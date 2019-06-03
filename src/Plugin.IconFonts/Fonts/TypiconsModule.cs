namespace Plugin.IconFonts.Fonts
{
    /// <summary>
    /// Defines the <see cref="TypiconsModule" /> icon module.
    /// </summary>
    /// <seealso cref="Plugin.IconFonts.IconModule" />
    public sealed class TypiconsModule : IconModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TypiconsModule" /> class.
        /// </summary>
        public TypiconsModule()
            : base("Typicons", "typicons", "iconfonts-typicons.ttf", TypiconsCollection.Icons)
        {
            // Intentionally left blank
        }
    }
}