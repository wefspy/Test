﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Osnova
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Opis2_1_2 : ContentPage
    {
        int CurDay;
        int CurWeek;
        public Opis2_1_2(int day, int week)
        {
            InitializeComponent();
            CurDay = day;
            CurWeek = week;
        }
        public void AddExerciseButton(object sender, EventArgs e)
        {
            Exercise exercise = new Exercise
            {
                Anim = "gif2_pushups.gif",
                Image = "pushups_obratnue",
                Day = CurDay,
                Week = CurWeek,
                ExType = ExType.Osnova,
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