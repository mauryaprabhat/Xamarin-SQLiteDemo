using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SQLiteDemo4
{
    public class StudentDB
    {
        SQLiteConnection _sqlconnection;
        public StudentDB()
        {
            _sqlconnection = DependencyService.Get<ISqlite>().GetConnection();
            _sqlconnection.CreateTable<Student>();

        }
        public IEnumerable<Student> GetStudents()
        {
            return (from t in _sqlconnection.Table<Student>()
                    select t).ToList();
        }

        //Get specific student  
        public Student GetStudent(int id)
        {
            return _sqlconnection.Table<Student>().FirstOrDefault(t => t.ID == id);
        }

        //Delete specific student  
        public void DeleteStudent(int id)
        {
            _sqlconnection.Delete<Student>(id);
        }

        //Delete all student  
        public void DeleteAllStudent()
        {
            _sqlconnection.DeleteAll<Student>();
        }

        //Add new student to DB  
        public void AddStusent(Student student)
        {
            _sqlconnection.Insert(student);
        }
    }
}
