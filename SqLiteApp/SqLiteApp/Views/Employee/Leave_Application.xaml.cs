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
	public partial class Leave_Application : ContentPage
	{
		public Leave_Application ()
		{
			InitializeComponent ();
		}

        public async void Send_clicked(object sender, EventArgs e)
        {
           await DisplayAlert("Message", "Leave_Application Application Successfully Send", "ok");
            await Navigation.PushAsync(new Emp_Home());

        }
    }
}