﻿using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace SecondApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            
            var toSecondActivityButton = FindViewById<Button>(Resource.Id.button1);
            var toWebViewActivityButton = FindViewById<Button>(Resource.Id.button2);
            var editText = FindViewById<EditText>(Resource.Id.editText1);
            
            toSecondActivityButton.Click += delegate
            {
                var text = editText.Text;
                var intent = new Intent(this, typeof(SecondActivity));
                intent.PutExtra("edittextvalue", text);
                StartActivity(intent);
            };

            toWebViewActivityButton.Click += delegate
            {
                var intent = new Intent(this, typeof(WebViewActivity));
                StartActivity(intent);
            };
        }        
    }
}