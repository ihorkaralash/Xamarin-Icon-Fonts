namespace Plugin.IconFonts.Fonts
{
    /// <summary>
    /// Defines the <see cref="MeteoconsModule" /> icon module.
    /// </summary>
    /// <seealso cref="Plugin.IconFonts.IconModule" />
    public sealed class MeteoconsModule : IconModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeteoconsModule" /> class.
        /// </summary>
        public MeteoconsModule()
            : base("Meteocons", "Meteocons", "iconfonts-meteocons.ttf", MeteoconsCollection.Icons)
        {
            // Intentionally left blank
        }
    }
}