﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SecondApp
{
    [Activity(Label = "Activity1")]
    public class SecondActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            // Create your application here

            ValueTuple toSecondActivityButton = FindViewById<Button>(Resource.Id.button1);
            toSecondActivityButton.Click += delegate
            {
                var intent = new Intent(this, typeof(SecondActivity));
                StartActivity(intent);
            };
        }
    }
}