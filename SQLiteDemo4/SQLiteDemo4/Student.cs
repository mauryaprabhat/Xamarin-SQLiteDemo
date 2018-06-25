using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteDemo4
{
    public class Student
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string  StudentName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        

        public Student()
        {

        }
    }
}
