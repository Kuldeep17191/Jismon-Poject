using SQLite;
using SqLiteApp.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SqLiteApp
{
	//[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SearchEmployee : ContentPage
	{
        public SQLiteConnection conn;
        public Employee postmodel;

        public SearchEmployee (string First_Name, string Last_Name, string Department, string Contact_No)
		{
			InitializeComponent ();

            Emp_First_Name.Text = First_Name;
            EmP_Last_Name.Text = Last_Name;
            Emp_Department.Text = Department;
            Emp_Phone_No.Text = Contact_No;




        }
	}
}