
using Android.App;
using Android.OS;
using Android.Widget;
using System.Diagnostics;

namespace SqlLiteExampleAndroid
{
	[Activity (Label = "SqlLiteExampleAndroid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			System.Diagnostics.Debug.WriteLine ("------ hello");
		
			//SqlDatabase.createDatabase ();
			//var p = SqlDatabase.insertUpdateData (null, "database1.db");
			//var x = SqlDatabase.findNumberRecords ("database1.db");
			//System.Diagnostics.Debug.WriteLine (x.Id + " ---- " + x.ToString());


			// Get our button from the layout resource,
			// and attach an event to it

			Button button = FindViewById<Button> (Resource.Id.myButton);

			Button createTableButton = FindViewById<Button> (Resource.Id.button1);
			
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks! {1}", count++, SqlDatabase.blap().FirstOrDefault());
			};

			createTableButton.Click += delegate {
				SqlDatabase.createTable();
				createTableButton.Text = "Table Created";

			};
		}
	}
		
}


