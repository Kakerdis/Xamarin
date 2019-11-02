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
using Xamarin.Essentials;

namespace SecondApp
{
    [Activity(Label = "Activity1")]
    public class SecondActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.second_layout);
            var text = Intent.GetStringExtra("edittextvalue");

            var textView = FindViewById<TextView>(Resource.Id.textView1);
            textView.Text = text;

            // Essentialsi osa

            var appName = AppInfo.Name;
            var packageName = AppInfo.PackageName;
            var version = AppInfo.VersionString;
            var build = AppInfo.BuildString;

            var duration = TimeSpan.FromSeconds(10);
            AppInfo.ShowSettingsUI();

            Vibration.Vibrate(duration);
        }
    }
}