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
        private DateTime now;
        public DateTime Now
        {
            get => now;
            set => now = value;
        }

        public CalenderModel()
        {
            Now = DateTime.Now;
        }
    }
}
