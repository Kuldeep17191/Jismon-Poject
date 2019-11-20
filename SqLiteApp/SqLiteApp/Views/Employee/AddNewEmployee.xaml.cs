using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SqLiteApp.Tables;

namespace SqLiteApp
{
    
    public partial class AddNewEmployee : ContentPage
	{
        public SQLiteConnection conn;
        public Employee regmodel;

        public AddNewEmployee ()
		{
			InitializeComponent ();
            conn = DependencyService.Get<Isqlite>().GetConnection();
            conn.CreateTable<Employee>();
        }

        public async void Ok_clicked(object sender, EventArgs e)
        {

            Employee reg = new Employee();

            reg.Userid = Userid.Text;
            reg.Password = Password.Text;

            int x = 0;
            try
            {
                x = conn.Insert(reg);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            if (x == 1)
            {
                await DisplayAlert("Alert", "You are Now Registered", "OK");
                await Navigation.PushAsync(new Admin_Home());

            }
            else
            {
                await DisplayAlert("Registration Failled!!!", "Please try again", "ERROR");
            }

        }

        public void Show_Clicked(object sender, EventArgs e)
        {


            try
            {
                Navigation.PushAsync(new DisplayPage()); //DisplayPage
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}