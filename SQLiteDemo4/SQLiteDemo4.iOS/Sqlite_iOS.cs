using SQLite.Net;
using System;
using System.Collections.Generic;
using System.IO;
using SQLiteDemo4.iOS;
using Xamarin.Forms;
using System.Text;

[assembly: Dependency(typeof(Sqlite_iOS))]
namespace SQLiteDemo4.iOS
{
    public  class Sqlite_iOS: ISite
    {
        public SQLiteConnection GetConnection()
        {
            var fileName = "Student.db3";
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentsPath, "..", "Library");
            var path = Path.Combine(libraryPath, fileName);

            var platform = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
            var connection = new SQLite.Net.SQLiteConnection(platform, path);

            return connection;
        }

    }

   
}
