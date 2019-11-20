using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Forms;
using SqLiteApp.Tables;

namespace SqLiteApp
{
    public partial class MainPage : ContentPage
    {
        public SQLiteConnection conn;
        public Employee empmodel;
        public MainPage()
        {
            InitializeComponent();
          

        }

        public async void Login_clicked(object sender, EventArgs e)
        {

            string Username_Val = UserId.Text;
            string Pasword_Val = Password.Text;
            conn = DependencyService.Get<Isqlite>().GetConnection();
            var data = conn.Table<Employee>();

            if (
            (string.IsNullOrEmpty(UserId.Text)))
            {
                await DisplayAlert("Error", "Enter User ID", "OK");
            }
            else if ((string.IsNullOrEmpty(Password.Text)))
            {
                await DisplayAlert("Error", "Please Enter Password", "OK");
            }

            else
            {

                var d1 = data.Where(x => Username_Val == x.Userid && Pasword_Val == x.Password).FirstOrDefault();
                if (d1 != null)
                {
                    await Navigation.PushAsync(new Emp_Home());
                }
                else if (Username_Val == "Admin" && Pasword_Val == "Admin123")
                {
                    await Navigation.PushAsync(new Admin_Home());

                }
                else
                    await DisplayAlert("Incorrect Details", "Please try again", "ERROR");
            }



        }

    

        public async void forgot_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ForgotPassword());
        }

    }
}

