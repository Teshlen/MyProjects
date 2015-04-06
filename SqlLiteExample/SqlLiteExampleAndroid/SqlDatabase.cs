using System;
using System.Threading.Tasks;
using System.Diagnostics;
using SQLite;
using System.IO;
using System.Collections.Generic;

namespace SqlLiteExampleAndroid
{
	public static class SqlDatabase
	{
		public static void createTable()
		{
			Person p = new Person{FirstName = "Teshlen", ID = 1, LastName = "Nadesan" };
			string dbPath = Path.Combine (
				Environment.GetFolderPath (Environment.SpecialFolder.Personal),
				"ormdemo.db3");
			var db = new SQLiteConnection (dbPath);
			db.CreateTable<Person> ();
			db.Insert (p);
		}

		public static TableQuery<Person> blap ()
		{
			Person p = new Person{FirstName = "Teshlen", ID = 1, LastName = "Nadesan" };
			string dbPath = Path.Combine (
				Environment.GetFolderPath (Environment.SpecialFolder.Personal),
				"ormdemo.db3");
			var db = new SQLiteConnection (dbPath);
			//db.CreateTable<Person> ();
			//db.Insert (p);

			var y = db.Table<Person> ();
			Debug.WriteLine("----------" +  y.FirstOrDefault ().FirstName + " " + y.FirstOrDefault().LastName);

			TableQuery<Person> i = from a in y
					where a.FirstName == "Teshlen"
				select a ;
			return i;
		}

	}
}

