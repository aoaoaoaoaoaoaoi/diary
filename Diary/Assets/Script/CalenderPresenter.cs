using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Model;

namespace Presenter
{
    public class CalenderPresenter : MonoBehaviour
    {
        //TODO:インターフェースにする
        [SerializeField] RectTransform dateRect;
        [SerializeField] RectTransform diaryRect;
        [SerializeReference, SubclassSelector] ITextPrinter dateText;
        [SerializeReference, SubclassSelector] IButtonPrinter prevButton;
        [SerializeReference, SubclassSelector] IButtonPrinter nextButton;
        [SerializeReference, SubclassSelector] IButtonPrinter todayButton;
        [SerializeField] IButtonPrinter day;

        //直接使用は非推奨
        [SerializeField] Calender calenderOnlyReference;
        ICalender Calender => calenderOnlyReference;

        // Start is called before the first frame update
        void Start()
        {
            ICalenderModel calenderModel = new CalenderModel();
            var today = calenderModel.DesignatedDayTime;
            Bind(calenderModel);
            dateText.Text = today.ToString("F");
            Calender.Initialize(()=> {
                //TODO:イージングをかける
                dateRect.anchoredPosition = dateRect.anchoredPosition + new Vector2(0, 80);
                diaryRect.anchoredPosition = diaryRect.anchoredPosition + new Vector2(0,950);
            }, today);
        }

        private void Bind(ICalenderModel model)
        {
            model.OnChangeDesignatedDayTime = (date) =>
            {
                RefreshCalender(date);
            };

            prevButton.OnClick(()=> {
                RefreshByAddMonth(model, -1);
            });

            nextButton.OnClick(() => {
                RefreshByAddMonth(model, 1);
            });

            todayButton.OnClick(() => {
                model.DesignatedDayTime = DateTime.Now;
            });
        }

        private void RefreshCalender(DateTime date)
        {
            dateText.Text = date.ToString("F");
            Calender.RefreshDays(date);
        }

        private void RefreshByAddMonth(ICalenderModel model ,int add)
        {
            var date = model.DesignatedDayTime;
            var firstDay = new DateTime(date.Year, date.Month, 1);
            var newDay = firstDay.AddMonths(add);
            model.DesignatedDayTime = newDay;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
