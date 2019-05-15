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
            base.OnPause();

            FindViewById(Resource.Id.GoogleButton).Click -= GoogleButtonClick;
            FindViewById(Resource.Id.TwitterButton).Click -= TwitterButtonClick;
            FindViewById(Resource.Id.FacebookButton).Click -= FacebookButtonClick;
            FindViewById(Resource.Id.PinterestButton).Click -= PinterestButtonClick;
            FindViewById(Resource.Id.LinkedinButton).Click -= LinkedinButtonClick;
            FindViewById(Resource.Id.WatsappButton).Click -= WatsappButtonClick;
            FindViewById(Resource.Id.GithubButton).Click -= GithubButtonClick;
        }

        private void GithubButtonClick(object sender, EventArgs e)
        {
            FindViewById<IconImage>(Resource.Id.Image).Icon = "fab-github";
            FindViewById<IconImage>(Resource.Id.Image).IconColor = new Color(GetColor(Resource.Color.githubBackground));
        }

        private void WatsappButtonClick(object sender, EventArgs e)
        {
            FindViewById<IconImage>(Resource.Id.Image).Icon = "fab-whatsapp";
            FindViewById<IconImage>(Resource.Id.Image).IconColor = new Color(GetColor(Resource.Color.watsappBackground));
        }

        private void LinkedinButtonClick(object sender, EventArgs e)
        {
            FindViewById<IconImage>(Resource.Id.Image).Icon = "fab-linkedin-in";
            FindViewById<IconImage>(Resource.Id.Image).IconColor = new Color(GetColor(Resource.Color.linkedinBackground));
        }

        private void PinterestButtonClick(object sender, EventArgs e)
        {
            FindViewById<IconImage>(Resource.Id.Image).Icon = "fab-pinterest";
            FindViewById<IconImage>(Resource.Id.Image).IconColor = new Color(GetColor(Resource.Color.pinterestBackground));
        }

        private void TwitterButtonClick(object sender, EventArgs e)
        {
            FindViewById<IconImage>(Resource.Id.Image).Icon = "fab-twitter";
            FindViewById<IconImage>(Resource.Id.Image).IconColor = new Color(GetColor(Resource.Color.twitterBackground));
        }

        private void GoogleButtonClick(object sender, EventArgs e)
        {
            FindViewById<IconImage>(Resource.Id.Image).Icon = "fab-google-plus-g";
            FindViewById<IconImage>(Resource.Id.Image).IconColor = new Color(GetColor(Resource.Color.googleBackground));
        }

        private void FacebookButtonClick(object sender, EventArgs e)
        {
            FindViewById<IconImage>(Resource.Id.Image).Icon = "fab-facebook-f";
            FindViewById<IconImage>(Resource.Id.Image).IconColor = new Color(GetColor(Resource.Color.facebookBackground));
        }
    }
}