using SQLite;
using SqLiteApp.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SqLiteApp.Views.Admin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Leave_Approval : ContentPage
	{
        public SQLiteConnection conn;
        public Leave_Application Leavemodel;
        public Leave_Approval ()
		{
			InitializeComponent ();
            conn = DependencyService.Get<Isqlite>().GetConnection();
            conn.CreateTable<Leave_Application>();
            DisplayDetails();
        }

        public void DisplayDetails()
        {

            //var details = (from x in conn.Table<Registration>() select x).ToList();
            var details1 = (from x in conn.Table<Leave_Application>() select x).ToList();
            myListView1.ItemsSource = details1;
        }

        public async void MyListView1_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var details1 = e.Item as Leave_Application;

            //await Navigation.PushAsync(new Leave_Display(details1.Leave_Heading,details1.Leave_Reason));
        }
    }
}