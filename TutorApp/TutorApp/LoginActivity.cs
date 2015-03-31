
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

namespace TutorApp
{
	[Activity (Label = "LoginActivity")]			
	public class LoginActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{ var count = 1;
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.StartPageLayout);

			Button loginButton = FindViewById<Button> (Resource.Id.continueButton);
			loginButton.Click += delegate {
				loginButton.Text = ++count+"";
			};
		}

	}
}

