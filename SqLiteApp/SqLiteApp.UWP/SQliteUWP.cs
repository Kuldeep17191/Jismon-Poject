using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SqLiteApp.UWP;
using Windows.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQliteUWP))]

namespace SqLiteApp.UWP
{
    public class SQliteUWP : Isqlite
    {
        SQLiteConnection Isqlite.GetConnection()
        {
            //throw new NotImplementedException();
            var dbase = "Mydatabase";
            var path = Path.Combine(ApplicationData.Current.LocalFolder.Path, dbase);

            return new SQLiteConnection(path);

        }
    }
}
