namespace Plugin.IconFonts.Fonts
{
    /// <summary>
    /// Defines the <see cref="MaterialModule" /> icon module.
    /// </summary>
    /// <seealso cref="Plugin.IconFonts.IconModule" />
    public sealed class MaterialModule : IconModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaterialModule" /> class.
        /// </summary>
        public MaterialModule()
            : base("Material Icons", "MaterialIcons-Regular", "iconfonts-material.ttf", MaterialCollection.Icons)
        {
            // Intentionally left blank
        }
    }
}