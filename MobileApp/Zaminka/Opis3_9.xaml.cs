using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Zaminka
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Opis3_9 : ContentPage
    {
        int CurDay;
        int CurWeek;
        public Opis3_9(int day, int week)
        {
            InitializeComponent();
            CurDay = day;
            CurWeek = week;
        }
        public void AddExerciseButton(object sender, EventArgs e)
        {
            Exercise exercise = new Exercise
            {
                Anim = "png8_tagayagodichi",
                Image = "taga_yagodichi",
                Day = CurDay,
                Week = CurWeek,
                ExType = ExType.Zaminka,
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