using System;
using System.Collections;
using System.Collections.Generic;

namespace Model
{
    public interface ICalenderModel
    {
        DateTime Now { get; set; }
    }

    public class CalenderModel : ICalenderModel
    {
        public CalenderModel()
        {
            Now = DateTime.Now;
        }

        private DateTime now;
        public DateTime Now
        {
            get => now;
            set => now = value;
        }
    }
}
