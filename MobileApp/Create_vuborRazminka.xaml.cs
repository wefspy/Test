using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileApp.Razminka;

namespace MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Create_vuborRazminka : ContentPage
    {
        int CurDay;
        int CurWeek;
        public Create_vuborRazminka(int day, int week)
        {
            InitializeComponent();
            CurDay = day;
            CurWeek = week;
        }

        private async void Opis1_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis1_1(CurDay, CurWeek));
        }
        private async void Opis1_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis1_2(CurDay, CurWeek));
        }
        private async void Opis1_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis1_3(CurDay, CurWeek));
        }
        private async void Opis1_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis1_4(CurDay, CurWeek));
        }
        private async void Opis1_5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis1_5(CurDay, CurWeek));
        }
        private async void Opis1_6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis1_6(CurDay, CurWeek));
        }
        private async void Opis1_7(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis1_7(CurDay, CurWeek));
        }
        private async void Opis1_8(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis1_8(CurDay, CurWeek));
        }
        private async void Opis1_9(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis1_9(CurDay, CurWeek));
        }
        private async void Opis1_10(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis1_10(CurDay, CurWeek));
        }
        private async void Opis1_11(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis1_11(CurDay, CurWeek));
        }

    }
}