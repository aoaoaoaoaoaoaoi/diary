using System;
using System.Collections;
using System.Collections.Generic;

namespace Diary
{
    public interface ICalenderModel
    {
        DateTime Now { get; set; }
    }

    public class CalenderModel : ICalenderModel
    {
        private static CalenderModel calenderModel = new CalenderModel();
        public CalenderModel()
        {
            Now = DateTime.Now;
        }

        public static ICalenderModel GetInstance()
        { 
            return calenderModel;
        }

        private DateTime now;
        public DateTime Now
        {
            get => now;
            set => now = value;
        }
    }
}
