using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SQLiteDemo4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudentList : ContentPage
    {
        public StudentDB _studentDB;

        public StudentList()
        {
            InitializeComponent();
            _studentDB = new StudentDB();
            var students = _studentDB.GetStudents();
            studentListView.ItemsSource = students;
        }
    }
}