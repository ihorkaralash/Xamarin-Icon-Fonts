namespace Plugin.IconFonts.Fonts
{
    /// <summary>
    /// Defines the <see cref="EntypoPlusModule" /> icon module.
    /// </summary>
    /// <seealso cref="Plugin.IconFonts.IconModule" />
    public sealed class EntypoPlusModule : IconModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntypoPlusModule" /> class.
        /// </summary>
        public EntypoPlusModule()
            : base("entypo-plus", "entypo-plus", "iconfonts-entypoplus.ttf", EntypoPlusCollection.Icons)
        {
            // Intentionally left blank
        }
    }
}