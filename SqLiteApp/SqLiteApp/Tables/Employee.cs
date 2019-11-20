using System;
using SQLite;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SqLiteApp.Tables
{
   public  class Employee
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Userid { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Department { get; set; }
        public string Password { get; set; }
        public string Contact_No { get; set; }
    }
}
