using System;
using System.Collections;
using System.Collections.Generic;

namespace Model
{
    public interface ICalenderModel
    {
        DateTime DesignatedDayTime { get; set; }
        Action<DateTime> OnChangeDesignatedDayTime { set; }
    }

    public class CalenderModel : ICalenderModel
    {
        public CalenderModel()
        {
            DesignatedDayTime = DateTime.Now;
        }

        private DateTime designatedDayTime;
        private Action<DateTime> onChangeDesignatedDayTime;
        public Action<DateTime> OnChangeDesignatedDayTime
        {
            set => onChangeDesignatedDayTime = value;
        }
        public DateTime DesignatedDayTime
        {
            get => designatedDayTime;
            set
            {
                designatedDayTime = value;
                onChangeDesignatedDayTime?.Invoke(value);
            }
        }
    }
}
