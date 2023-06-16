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
    public partial class PopUpCardExercise : Rg.Plugins.Popup.Pages.PopupPage
    {
        int CurDay;
        int CurWeek;
        public PopUpCardExercise(CardExercise cardExercise, int day, int week)
        {
            InitializeComponent();
            Name.Text = cardExercise.Name;
            GIF.Source = cardExercise.GIF;
            Description.Text = cardExercise.Description;
        }

        public void AddExerciseButton(object sender, EventArgs e)
        {
            Exercise exercise = new Exercise
            {
                Anim = "gifen_pushups.gif",
                Image = "pushups_classic",
                Day = CurDay,
                Week = CurWeek,
                ExType = ExType.Osnova,
                NumberApproaches = CountApproaches.Text.Trim(),
                NumberRepetitions = CountRepetitions.Text.Trim(),
                Time = int.Parse(Time.Text.Trim())
            };

            App.Db.SaveExercise(exercise);
            CountApproaches.Text = "";
            CountRepetitions.Text = "";
            Time.Text = "";
        }
    }
}