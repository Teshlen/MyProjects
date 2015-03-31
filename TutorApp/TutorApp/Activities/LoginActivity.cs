
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
using System.Threading.Tasks;
using TutorAppPortableLibrary.Models;

namespace TutorApp.Actvities
{
	[Activity (Label = "LoginActivity")]			
	public class LoginActivity : Activity
	{
		public TutorModel t { get; set; }

		private TextView UserNameTextView;
		private TextView PasswordTextView;

		protected override void OnCreate (Bundle bundle)
		{ 
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.StartPageLayout);

			UserNameTextView = FindViewById<TextView> (Resource.Id.editText1);
			PasswordTextView = FindViewById<TextView> (Resource.Id.editText2);
			 



			Button loginButton = FindViewById<Button> (Resource.Id.continueButton);
			loginButton.Click += delegate {
				StartActivity(typeof(AddNewLesson));
			};
		}

		public async Task help()
		{
			TutorModel tq = new TutorModel{ Name = "hello Teshlen", password = " "};

			FileAccessor f = new FileAccessor ();
			await f.WriteObjectAsync ("test.txt", tq);
		}

		public async Task help1()
		{
			FileAccessor f = new FileAccessor ();
			var readresult = await f.ReadObjectAsync<TutorModel> ("test.txt");
			t = readresult.Data;
		}


	}
}

