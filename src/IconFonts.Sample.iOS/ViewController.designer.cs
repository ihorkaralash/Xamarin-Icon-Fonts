// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//

using Foundation;

namespace IconFonts.Sample.iOS
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		Plugin.IconFonts.iOS.IconButton FacebookButton { get; set; }

		[Outlet]
		Plugin.IconFonts.iOS.IconButton GithubButton { get; set; }

		[Outlet]
		Plugin.IconFonts.iOS.IconButton GoogleButton { get; set; }

		[Outlet]
		Plugin.IconFonts.iOS.IconImage Image { get; set; }

		[Outlet]
		IconFonts.Sample.iOS.CustomIconLabel Label { get; set; }

		[Outlet]
		Plugin.IconFonts.iOS.IconButton LinkedinButton { get; set; }

		[Outlet]
		Plugin.IconFonts.iOS.IconButton PinterestButton { get; set; }

		[Outlet]
		Plugin.IconFonts.iOS.IconButton TwitterButton { get; set; }

		[Outlet]
		Plugin.IconFonts.iOS.IconButton WatsappButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (FacebookButton != null) {
				FacebookButton.Dispose ();
				FacebookButton = null;
			}

			if (GithubButton != null) {
				GithubButton.Dispose ();
				GithubButton = null;
			}

			if (GoogleButton != null) {
				GoogleButton.Dispose ();
				GoogleButton = null;
			}

			if (LinkedinButton != null) {
				LinkedinButton.Dispose ();
				LinkedinButton = null;
			}

			if (PinterestButton != null) {
				PinterestButton.Dispose ();
				PinterestButton = null;
			}

			if (TwitterButton != null) {
				TwitterButton.Dispose ();
				TwitterButton = null;
			}

			if (WatsappButton != null) {
				WatsappButton.Dispose ();
				WatsappButton = null;
			}

			if (Image != null) {
				Image.Dispose ();
				Image = null;
			}

			if (Label != null) {
				Label.Dispose ();
				Label = null;
			}
		}
	}
}
