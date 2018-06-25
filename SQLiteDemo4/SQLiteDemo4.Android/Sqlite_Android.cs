//using Android.OS;
using SQLite.Net;
using SQLiteDemo4.Droid;
using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(Sqlite_Android))]
namespace SQLiteDemo4.Droid
{
    class Sqlite_Android : ISqlite
    {
        public SQLiteConnection GetConnection()
        {
            var filename = "StudentDatabase.db3";
            var documentspath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentspath, filename);

            var platform = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var connection = new SQLite.Net.SQLiteConnection(platform, path);
            return connection;
        }
    }
}