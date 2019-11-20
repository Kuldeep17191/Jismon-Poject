using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using SqLiteApp.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(SQliteAnroid))]
namespace SqLiteApp.Droid
{
    public class SQliteAnroid : Isqlite
    {
        SQLiteConnection Isqlite.GetConnection()
        {
            //throw new NotImplementedException();
            var dbase = "Mydatabase";
            var path = Path.Combine(System.Environment.GetFolderPath
                (System.Environment.SpecialFolder.Personal), dbase);

            return new SQLiteConnection(path);

        }
    }
}