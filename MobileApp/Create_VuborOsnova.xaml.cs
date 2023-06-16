using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileApp.Osnova;

namespace MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Create_VuborOsnova : ContentPage
    {
        int CurDay;
        int CurWeek;
        public Create_VuborOsnova(int day, int week)
        {
            InitializeComponent();
            CurDay = day;
            CurWeek = week;
        }
        protected override void OnAppearing()
        {
            HandsCollection.ItemsSource = App.BankEx.GetBasicExercisesByType(PartBody.Hands);
            LegsCollection.ItemsSource = App.BankEx.GetBasicExercisesByType(PartBody.Legs);
            PressCollection.ItemsSource = App.BankEx.GetBasicExercisesByType(PartBody.Press);
            ChestCollection.ItemsSource = App.BankEx.GetBasicExercisesByType(PartBody.Chest);
            BackCollection.ItemsSource = App.BankEx.GetBasicExercisesByType(PartBody.Back);
        }
        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            hands.IsVisible = true;
            hands_create.IsVisible = false;
            hands_back.IsVisible = true;
        }
        private void ImageButton_Clicked1_1(object sender, EventArgs e)
        {
            hands.IsVisible = false;
            hands_create.IsVisible = true;
            hands_back.IsVisible = false;
        }
        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            legs.IsVisible = true;
            legs_create.IsVisible = false;
            legs_back.IsVisible = true;
        }
        private void ImageButton_Clicked_1_1(object sender, EventArgs e)
        {
            legs.IsVisible = false;
            legs_create.IsVisible = true;
            legs_back.IsVisible = false;
        }

        private void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            press.IsVisible = true;
            press_create.IsVisible = false;
            press_back.IsVisible = true;
        }
        private void ImageButton_Clicked_2_1(object sender, EventArgs e)
        {
            press.IsVisible = false;
            press_create.IsVisible = true;
            press_back.IsVisible = false;
        }

        private void ImageButton_Clicked_3(object sender, EventArgs e)
        {
            grud.IsVisible = true;
            grud_create.IsVisible = false;
            grud_back.IsVisible = true;
        }
        private void ImageButton_Clicked_3_1(object sender, EventArgs e)
        {
            grud.IsVisible = false;
            grud_create.IsVisible = true;
            grud_back.IsVisible = false;
        }

        private void ImageButton_Clicked_4(object sender, EventArgs e)
        {
            back.IsVisible = true;
            back_create.IsVisible = false;
            back_back.IsVisible = true;
        }
        private void ImageButton_Clicked_4_1(object sender, EventArgs e)
        {
            back.IsVisible = false;
            back_create.IsVisible = true;
            back_back.IsVisible = false;
        }
        private async void Opis2_1_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis2_1_1(CurDay, CurWeek));
        }
        private async void Opis2_1_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis2_1_2(CurDay, CurWeek));
        }
        private async void Opis2_1_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis2_1_3(CurDay, CurWeek));
        }
        private async void Opis2_1_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis2_1_4(CurDay, CurWeek));
        }
        private async void Opis2_2_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis2_2_1(CurDay, CurWeek));
        }
        private async void Opis2_2_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis2_2_2(CurDay, CurWeek));
        }
        private async void Opis2_2_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis2_2_3(CurDay, CurWeek));
        }
        private async void Opis2_2_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis2_2_4(CurDay, CurWeek));
        }
        private async void Opis2_3_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis2_3_1(CurDay, CurWeek));
        }
        private async void Opis2_3_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis2_3_2(CurDay, CurWeek));
        }
        private async void Opis2_3_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis2_3_3(CurDay, CurWeek));
        }
        private async void Opis2_3_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis2_3_4(CurDay, CurWeek));
        }
        private async void Opis2_4_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis2_4_1(CurDay, CurWeek));
        }
        private async void Opis2_4_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis2_4_2(CurDay, CurWeek));
        }
        private async void Opis2_5_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis2_5_1(CurDay, CurWeek));
        }
        private async void Opis2_5_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis2_5_2(CurDay, CurWeek));
        }
        private async void Opis2_5_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis2_5_3(CurDay, CurWeek));
        }
        private async void Opis2_5_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis2_5_4(CurDay, CurWeek));
        }
    }
}