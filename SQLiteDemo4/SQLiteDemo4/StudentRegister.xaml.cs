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
    public partial class StudentRegister : ContentPage
    {
        public StudentDB _studentDB;
        public Student _student;
        public StudentRegister()
        {
            _studentDB = new StudentDB();
            InitializeComponent();
        }

        public void AddStudent_Clicked(object sender, EventArgs e)
        {
            _student = new Student();
            _student.StudentName = name.Text;
            _student.Address = address.Text;
            _student.Phone = phone.Text;
            _studentDB.AddStusent(_student);
            name.Text = string.Empty;
            address.Text = string.Empty;
            phone.Text = string.Empty;

        }

        public void ShowStudent_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new StudentList());
        }

        public void DeleteAll_Clicked(object sender, EventArgs e)
        {

            _studentDB.DeleteAllStudent();
        }
    }
}