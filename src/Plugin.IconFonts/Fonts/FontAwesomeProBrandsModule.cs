namespace Plugin.IconFonts.Fonts
{
	/// <summary>
    /// Defines the <see cref="FontAwesomeProBrandsModule" /> icon module.
    /// </summary>
    /// <seealso cref="Plugin.IconFonts.IconModule" />
    public sealed class FontAwesomeProBrandsModule : IconModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FontAwesomeProBrandsModule" /> class.
        /// </summary>
        public FontAwesomeProBrandsModule()
            : base("Font Awesome 5 Pro Brands", "FontAwesome5ProBrandsRegular", "iconfonts-fontawesome-pro-brands.ttf", FontAwesomeProCollection.BrandIcons)
        {
            // Intentionally left blank
        }
    }
}