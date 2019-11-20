using SQLite;
using SqLiteApp.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SqLiteApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DisplayPage : ContentPage
	{
        public SQLiteConnection conn;
        public Employee empmodel;
    

        public DisplayPage ()
		{
			InitializeComponent ();
            conn = DependencyService.Get<Isqlite>().GetConnection();
            conn.CreateTable<Employee>();
            DisplayDetails();

		}
        public void DisplayDetails()
        {

            //var details = (from x in conn.Table<Registration>() select x).ToList();
            var details = (from x in conn.Table<Employee>() select x).ToList();
            myListView.ItemsSource = details;
        }

        public async   void MyListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var details = e.Item as Employee;
            
            

            await Navigation.PushAsync(new SearchEmployee(details.First_Name,details.Last_Name,details.Department,details.Contact_No ));
        }
    }
}