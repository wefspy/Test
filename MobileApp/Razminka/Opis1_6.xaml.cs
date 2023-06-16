using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Razminka
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Opis1_6 : ContentPage
    {
        int CurDay;
        int CurWeek;
        public Opis1_6(int day, int week)
        {
            InitializeComponent();
            CurDay = day;
            CurWeek = week;
        }
        public void AddExerciseButton(object sender, EventArgs e)
        {
            Exercise exercise = new Exercise
            {
                Anim = "gif6_vrashkorpus.gif",
                Image = "vrash_korpus",
                Day = CurDay,
                Week = CurWeek,
                ExType = ExType.Razminka,
                NumberApproaches = podhodHolder.Text.Trim(),
                NumberRepetitions = povtorHolder.Text.Trim(),
                Time = int.Parse(timeHolder.Text.Trim())
            };

            App.Db.SaveExercise(exercise);
            podhodHolder.Text = "";
            povtorHolder.Text = "";
            timeHolder.Text = "";

        }
    }
}