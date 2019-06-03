using System;
using UIKit;

namespace IconFonts.Sample.iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

            GoogleButton.TouchUpInside += GoogleButtonClick;
            TwitterButton.TouchUpInside += TwitterButtonClick;
            FacebookButton.TouchUpInside += FacebookButtonClick;
            PinterestButton.TouchUpInside += PinterestButtonClick;
            LinkedinButton.TouchUpInside += LinkedinButtonClick;
            WatsappButton.TouchUpInside += WatsappButtonClick;
            GithubButton.TouchUpInside += GithubButtonClick;
        }

        public override void ViewDidDisappear(bool animated)
        {
            GoogleButton.TouchUpInside -= GoogleButtonClick;
            TwitterButton.TouchUpInside -= TwitterButtonClick;
            FacebookButton.TouchUpInside -= FacebookButtonClick;
            PinterestButton.TouchUpInside -= PinterestButtonClick;
            LinkedinButton.TouchUpInside -= LinkedinButtonClick;
            WatsappButton.TouchUpInside -= WatsappButtonClick;
            GithubButton.TouchUpInside -= GithubButtonClick;

            base.ViewDidDisappear(animated);
        }

        private void GithubButtonClick(object sender, EventArgs e)
        {
            Image.Icon = "fab-github";
            Image.IconColor = ColorConstants.GithubBackground;

            Label.IconColor = ColorConstants.GithubBackground;
            Label.Text = "{fab-github} Github button clicked";
        }

        private void WatsappButtonClick(object sender, EventArgs e)
        {
            Image.Icon = "fab-whatsapp";
            Image.IconColor = ColorConstants.WatsappBackground;

            Label.IconColor = ColorConstants.WatsappBackground;
            Label.Text = "{fab-whatsapp} Whatsapp button clicked";
        }

        private void LinkedinButtonClick(object sender, EventArgs e)
        {
            Image.Icon = "fab-linkedin-in";
            Image.IconColor = ColorConstants.LinkedinBackground;

            Label.IconColor = ColorConstants.LinkedinBackground;
            Label.Text = "{fab-linkedin-in} Linkedin button clicked";
        }

        private void PinterestButtonClick(object sender, EventArgs e)
        {
            Image.Icon = "fab-pinterest";
            Image.IconColor = ColorConstants.PinterestBackground;

            Label.IconColor = ColorConstants.PinterestBackground;
            Label.Text = "{fab-pinterest} Pinterest button clicked";
        }

        private void TwitterButtonClick(object sender, EventArgs e)
        {
            Image.Icon = "fab-twitter";
            Image.IconColor = ColorConstants.TwitterBackground;

            Label.IconColor = ColorConstants.TwitterBackground;
            Label.Text = "{fab-twitter} Twitter button clicked";
        }

        private void GoogleButtonClick(object sender, EventArgs e)
        {
            Image.Icon = "fab-google-plus-g";
            Image.IconColor = ColorConstants.GoogleBackground;

            Label.IconColor = ColorConstants.GoogleBackground;
            Label.Text = "{fab-google-plus-g} Google button clicked";
        }

        private void FacebookButtonClick(object sender, EventArgs e)
        {
            Image.Icon = "fab-facebook-f";
            Image.IconColor = ColorConstants.FacebookBackground;

            Label.IconColor = ColorConstants.FacebookBackground;
            Label.Text = "{fab-facebook-f} Facebook button clicked";
        }
    }
}