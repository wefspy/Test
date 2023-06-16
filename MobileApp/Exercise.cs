using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MobileApp
{
    public class Exercise
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int Day { get; set; }
        public int Week { get; set; }
        public ExType ExType { get; set; }
        public string Anim { get; set; }
        public string Image { get; set; }
        public string NumberApproaches { get; set; }
        public string NumberRepetitions { get; set; }
        public int Time { get; set; }
    }
}
