using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]


    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        private async void League_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new League());

        }

        private async void Cup_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cup());
        }

        private async void Program_Now(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProgramNow());
        }

        private async void All_Achivement(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AllAchivement());
        }
    }

}
