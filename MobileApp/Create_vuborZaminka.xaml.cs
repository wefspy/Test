using MobileApp.Razminka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileApp.Zaminka;

namespace MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Create_vuborZaminka : ContentPage
    {
        int CurDay;
        int CurWeek;
        public Create_vuborZaminka(int day, int week)
        {
            InitializeComponent();
            CurDay = day;
            CurWeek = week;
        }
        private async void Opis3_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis3_1(CurDay, CurWeek));
        }
        private async void Opis3_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis3_2(CurDay, CurWeek));
        }
        private async void Opis3_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis3_3(CurDay, CurWeek));
        }
        private async void Opis3_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis3_4(CurDay, CurWeek));
        }
        private async void Opis3_5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis3_5(CurDay, CurWeek));
        }
        private async void Opis3_6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis3_6(CurDay, CurWeek));
        }
        private async void Opis3_7(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis3_7(CurDay, CurWeek));
        }
        private async void Opis3_8(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis3_8(CurDay, CurWeek));
        }
        private async void Opis3_9(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis3_9(CurDay, CurWeek));
        }
        private async void Opis3_10(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis3_10(CurDay, CurWeek));
        }
        

    }
}