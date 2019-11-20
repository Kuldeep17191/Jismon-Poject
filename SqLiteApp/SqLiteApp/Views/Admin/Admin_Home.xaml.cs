using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SqLiteApp.Views.Admin;

namespace SqLiteApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Admin_Home : ContentPage
	{
		public Admin_Home ()
		{
			InitializeComponent ();
		}

        public async void Add_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PopAsync(new AddNewEmployee());
            await Navigation.PushAsync(new AddNewEmployee());
        }

        public async void  Leave_Approval_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Leave_Approval());
        }

        private void Password_Reset_Clicked(object sender, EventArgs e)
        {

        }
    }
}