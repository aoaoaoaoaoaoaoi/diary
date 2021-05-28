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
        void Initialize(Action onClick, DateTime today);
        Vector2 Position { get; set; }
    }
    
    public class Calender : MonoBehaviour, ICalender
    {
        [SerializeField] ButtonMonoView day;
        private IReadOnlyList<IButtonMonoPrinter> days;

        private RectTransform rectTransform;
        public Vector2 Position
        {
            get => rectTransform.anchoredPosition;
            set => rectTransform.anchoredPosition = value;
        }

        //TODO:コンフィグファイルに移動
        private const int dayCount = 42;

        // Start is called before the first frame update
        void Start()
        {
        }

        public void Initialize(Action onClick, DateTime today)
        {
            rectTransform = this.gameObject.GetComponent<RectTransform>();
            var buttonArray = new IButtonMonoPrinter[dayCount];
            for (int i = 0; i < dayCount; ++i)
            {
                buttonArray[i] = (Instantiate(day, transform) as IButtonMonoPrinter);
                buttonArray[i].OnClick(onClick);
            }
            days = buttonArray;
            RefreshDays(today);
        }

        //曜日を受け取って順番に番号を振る
        public void RefreshDays(DateTime today)
        {
            var firstDay = new DateTime(today.Year, today.Month, 1);
            var lastDay = firstDay.AddMonths(1).AddDays(-1.0);

            //月の初めの曜日までActiveをfalseにする
            for (int i = 0; i < (int)firstDay.DayOfWeek; ++i)
            {
                days[i].SetInEnable();
            }
            //月の数字を入力する
            var firstIndex = (int)firstDay.DayOfWeek;
            var lastIndex = firstIndex + (lastDay.Day - 1);
            for (int i = firstIndex; i <= lastIndex; ++i)
            {
                days[i].SetEnable();
                days[i].Text = $"{i - firstIndex + 1}";
            }
            //月の終わりより後のActiveをfalseにする
            for (int i = lastIndex + 1; i < days.Count; ++i)
            {
                days[i].SetInEnable();
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
