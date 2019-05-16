using System;
using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Support.V7.App;
using Plugin.Iconize;

namespace Iconize.Sample.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
        }

        protected override void OnResume()
        {
            base.OnResume();

            FindViewById(Resource.Id.GoogleButton).Click += GoogleButtonClick;
            FindViewById(Resource.Id.TwitterButton).Click += TwitterButtonClick;
            FindViewById(Resource.Id.FacebookButton).Click += FacebookButtonClick;
            FindViewById(Resource.Id.PinterestButton).Click += PinterestButtonClick;
            FindViewById(Resource.Id.LinkedinButton).Click += LinkedinButtonClick;
            FindViewById(Resource.Id.WatsappButton).Click += WatsappButtonClick;
            FindViewById(Resource.Id.GithubButton).Click += GithubButtonClick;
        }

        protected override void OnPause()
        {
            FindViewById(Resource.Id.GoogleButton).Click -= GoogleButtonClick;
            FindViewById(Resource.Id.TwitterButton).Click -= TwitterButtonClick;
            FindViewById(Resource.Id.FacebookButton).Click -= FacebookButtonClick;
            FindViewById(Resource.Id.PinterestButton).Click -= PinterestButtonClick;
            FindViewById(Resource.Id.LinkedinButton).Click -= LinkedinButtonClick;
            FindViewById(Resource.Id.WatsappButton).Click -= WatsappButtonClick;
            FindViewById(Resource.Id.GithubButton).Click -= GithubButtonClick;

            base.OnPause();
        }

        private void GithubButtonClick(object sender, EventArgs e)
        {
            FindViewById<IconImage>(Resource.Id.Image).Icon = "fab-github";
            FindViewById<IconImage>(Resource.Id.Image).IconColor = new Color(GetColor(Resource.Color.githubBackground));

            FindViewById<CustomIconLabel>(Resource.Id.Label).IconColor = new Color(GetColor(Resource.Color.githubBackground));
            FindViewById<CustomIconLabel>(Resource.Id.Label).Text = "{fab-github} Github button clicked";
        }

        private void WatsappButtonClick(object sender, EventArgs e)
        {
            FindViewById<IconImage>(Resource.Id.Image).Icon = "fab-whatsapp";
            FindViewById<IconImage>(Resource.Id.Image).IconColor = new Color(GetColor(Resource.Color.watsappBackground));

            FindViewById<CustomIconLabel>(Resource.Id.Label).IconColor = new Color(GetColor(Resource.Color.watsappBackground));
            FindViewById<CustomIconLabel>(Resource.Id.Label).Text = "{fab-whatsapp} Whatsapp button clicked";
        }

        private void LinkedinButtonClick(object sender, EventArgs e)
        {
            FindViewById<IconImage>(Resource.Id.Image).Icon = "fab-linkedin-in";
            FindViewById<IconImage>(Resource.Id.Image).IconColor = new Color(GetColor(Resource.Color.linkedinBackground));

            FindViewById<CustomIconLabel>(Resource.Id.Label).IconColor = new Color(GetColor(Resource.Color.linkedinBackground));
            FindViewById<CustomIconLabel>(Resource.Id.Label).Text = "{fab-linkedin-in} Linkedin button clicked";
        }

        private void PinterestButtonClick(object sender, EventArgs e)
        {
            FindViewById<IconImage>(Resource.Id.Image).Icon = "fab-pinterest";
            FindViewById<IconImage>(Resource.Id.Image).IconColor = new Color(GetColor(Resource.Color.pinterestBackground));

            FindViewById<CustomIconLabel>(Resource.Id.Label).IconColor = new Color(GetColor(Resource.Color.pinterestBackground));
            FindViewById<CustomIconLabel>(Resource.Id.Label).Text = "{fab-pinterest} Pinterest button clicked";
        }

        private void TwitterButtonClick(object sender, EventArgs e)
        {
            FindViewById<IconImage>(Resource.Id.Image).Icon = "fab-twitter";
            FindViewById<IconImage>(Resource.Id.Image).IconColor = new Color(GetColor(Resource.Color.twitterBackground));

            FindViewById<CustomIconLabel>(Resource.Id.Label).IconColor = new Color(GetColor(Resource.Color.twitterBackground));
            FindViewById<CustomIconLabel>(Resource.Id.Label).Text = "{fab-twitter} Twitter button clicked";
        }

        private void GoogleButtonClick(object sender, EventArgs e)
        {
            FindViewById<IconImage>(Resource.Id.Image).Icon = "fab-google-plus-g";
            FindViewById<IconImage>(Resource.Id.Image).IconColor = new Color(GetColor(Resource.Color.googleBackground));

            FindViewById<CustomIconLabel>(Resource.Id.Label).IconColor = new Color(GetColor(Resource.Color.googleBackground));
            FindViewById<CustomIconLabel>(Resource.Id.Label).Text = "{fab-google-plus-g} Google button clicked";
        }

        private void FacebookButtonClick(object sender, EventArgs e)
        {
            FindViewById<IconImage>(Resource.Id.Image).Icon = "fab-facebook-f";
            FindViewById<IconImage>(Resource.Id.Image).IconColor = new Color(GetColor(Resource.Color.facebookBackground));

            FindViewById<CustomIconLabel>(Resource.Id.Label).IconColor = new Color(GetColor(Resource.Color.facebookBackground));
            FindViewById<CustomIconLabel>(Resource.Id.Label).Text = "{fab-facebook-f} Facebook button clicked";
        }
    }
}