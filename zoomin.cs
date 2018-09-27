using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App10.Droid
{
    [Activity(Label = "zoomin")]
    public class zoomin : Activity
    {

        ImageView zout;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.zomin);
            // Create your application here

            zout = FindViewById<ImageView>(Resource.Id.zzout);
            zout.Click += Moveout;
        }

        private void Moveout(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(MainActivity));
            intent.PutExtra("part", "neck");
            StartActivity(intent);

        }
    }
}