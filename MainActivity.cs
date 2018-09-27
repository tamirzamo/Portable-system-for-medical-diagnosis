using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;
using Android.Support.V7.App;
using Microsoft.WindowsAzure.MobileServices;

namespace App10.Droid
{
    [Activity(Label = "App10", MainLauncher = true)]
    public class MainActivity : Activity
    {
        ImageView humanbody,zombut;
       

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it

            humanbody = FindViewById<ImageView>(Resource.Id.humpic);
            zombut = FindViewById<ImageView>(Resource.Id.zombut);
            humanbody.Click += MoveDiagnose;
            zombut.Click += Movein;


        }
        private void MoveDiagnose(object sender,EventArgs e)
        {
            var intent = new Intent(this, typeof(DignoseActivity));
            intent.PutExtra("part", "neck");
            StartActivity(intent);

        }

        private void Movein(object sender, EventArgs e)
        { 
            var intent = new Intent(this, typeof(zoomin));
            intent.PutExtra("part", "neck");
            StartActivity(intent);

        }
    }
}

