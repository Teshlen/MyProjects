
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
	[Activity (Label = "AddNewLesson")]			
	public class AddNewLesson : Activity
	{
		AutoCompleteTextView TutorSessionNameView;
		AutoCompleteTextView SubjectView;
		DatePicker date;
		Button addNewLessonButton;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.AddNewLessonLayout);

			// Create your application here
			TutorSessionNameView = FindViewById<AutoCompleteTextView> (Resource.Id.tutorName);
			SubjectView = FindViewById<AutoCompleteTextView> (Resource.Id.subject);
			date = FindViewById<DatePicker> (Resource.Id.datePicker1);
			addNewLessonButton = FindViewById<Button> (Resource.Id.addNewLessonButton);

			addNewLessonButton.Click += delegate {
				Toast.MakeText(this, " " + date.DateTime.ToString(), ToastLength.Long).Show();
			}; 


		}
	}
}

