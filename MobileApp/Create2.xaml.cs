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
    public partial class Create2 : ContentPage
    {
        bool[] Days;
        bool[] Weeks;
        private int curDay;
        private int curWeek;
        public Create2(bool[] days, bool[] weeks)
        {
            InitializeComponent();
            Days = days;
            Weeks = weeks;
            GetCurDayAndWeek();
        }
        protected override void OnAppearing()
        {
            ShowExercises(RazminkaCollection, ExType.Razminka);
            ShowExercises(OsnovaCollection, ExType.Osnova);
            ShowExercises(ZaminkaCollection, ExType.Zaminka);
        }
        public void ShowExercises(CollectionView collectionView, ExType exType)
        {
            collectionView.ItemsSource = App.Db.GetCreateExs(curDay, curWeek, exType);
        }

        private void GetCurDayAndWeek()
        {
            for(int i = 0; i < 7; i++)
                if (Days[i])
                {
                    Days[i] = false;
                    curDay = i;
                    break;
                }
        }

        private bool NeedContinue()
        {
            return Days.Any(day => day);
        }

        private async void ContinueOrEnd(object sender, EventArgs e)
        {
            if (NeedContinue()) await Navigation.PushAsync(new Create2(Days, Weeks));
            else 
            {
                FinishCreateProgram();
                await Navigation.PushAsync(new Page2()); // Переделать!! Куда будет выбрасывать после создание тренировки.
            }
        }

        private void FinishCreateProgram()
        {
            App.Db.TransferFromCreateToCurEx(ProgramType.Created);
            App.Db.RestartDate();
        }

        private void OnDeleteButton_Clicked(object sender, EventArgs e)
        {
            var imageButton = (ImageButton)sender;
            int imageId = (int)imageButton.CommandParameter;
            App.Db.DeleteExercise(imageId);
            OnAppearing();
        }

        private async void Create_VuborRazminka(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Create_vuborRazminka(curDay, curWeek));
        }
        private async void Create_VuborOsnova(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Create_VuborOsnova(curDay, curWeek));
        }
        private async void Create_VuborZaminka(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Create_vuborZaminka(curDay, curWeek));
        }
    }
}