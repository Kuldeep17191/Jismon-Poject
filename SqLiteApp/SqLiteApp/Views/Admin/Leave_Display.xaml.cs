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
	public partial class Leave_Display : ContentPage
	{
		public Leave_Display (string Heading,string Reason)
		{
			InitializeComponent ();
            Leave_Heading.Text = Heading;
            Leave_Reason.Text = Reason;


        }

        private void Approved_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("", "Leave Approved", "ok");
        }

        private void Reject_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("", "Leave Rejected", "ok");
        }
    }
}