namespace Plugin.IconFonts.Fonts
{
    /// <summary>
    /// Defines the <see cref="IoniconsModule" /> icon module.
    /// </summary>
    /// <seealso cref="Plugin.IconFonts.IconModule" />
    public sealed class IoniconsModule : IconModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoniconsModule" /> class.
        /// </summary>
        public IoniconsModule()
            : base("Ionicons", "Ionicons", "iconfonts-ionicons.ttf", IoniconsCollection.Icons)
        {
            // Intentionally left blank
        }
    }
}