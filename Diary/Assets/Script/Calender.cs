using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using View;

namespace Presenter
{
    interface ICalender
    {
        void RefreshDays(DateTime today);
    }

    //TODO：インターフェースから操作できるようにする
    public class Calender : MonoBehaviour, ICalender
    {
        [SerializeField] ButtonMonoView day;
        private IReadOnlyCollection<IButtonMonoPrinter> days;

        //TODO:コンフィグファイルに移動
        private const int dayCount = 42;

        // Start is called before the first frame update
        void Start()
        {
            var buttonArray = new IButtonMonoPrinter[dayCount];
            for (int i=0;i<dayCount;++i)
            {
                buttonArray[i] = (Instantiate(day, transform) as IButtonMonoPrinter); 
            }
            days = buttonArray;
        }

        //曜日を受け取って順番に番号を振る
        public void RefreshDays(DateTime today)
        {
            var firstDay = new DateTime(today.Year, today.Month, 1);

            //月の初めの曜日までActiveをfalseにする
            for (int i=0; i < (int)firstDay.DayOfWeek; ++i)
            {
                //days[i].setIna
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
