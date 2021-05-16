using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Model;

namespace Presenter
{
    public class CalenderPresenter : MonoBehaviour
    {
        [SerializeReference, SubclassSelector] ITextPrinter dateText;
        [SerializeReference, SubclassSelector] IButtonPrinter prevButton;
        [SerializeReference, SubclassSelector] IButtonPrinter nextButton;
        [SerializeField] IButtonPrinter day;

        //’¼ÚŽg—p‚Í”ñ„§
        [SerializeField] Calender calenderOnlyReference;
        ICalender Calender => calenderOnlyReference;

        ICalenderModel calenderModel;

        // Start is called before the first frame update
        void Start()
        {
            calenderModel = new CalenderModel();
            var today = calenderModel.Now;
            dateText.Text = today.ToString("F");
            Calender.RefreshDays(today);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
