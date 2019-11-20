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
	public partial class Emp_Home : ContentPage

    {
		public Emp_Home ()
		{
			InitializeComponent ();
		}


        public async void Employee_Details_Clicked(object sender, EventArgs e)
        {
            
            
                await Navigation.PushAsync(new DisplayPage());

        }

        public async void Leave_Application_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Leave_Application());
        }

        private void Company_news_Clicked(object sender, EventArgs e)
        {

        }

        private void Company_policy_Clicked(object sender, EventArgs e)
        {

        }
    }
}