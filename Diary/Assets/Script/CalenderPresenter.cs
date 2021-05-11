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
        //[SerializeReference, SubclassSelector] List<IButtonPrinter> dayButtons;

        ICalenderModel calenderModel;

        // Start is called before the first frame update
        void Start()
        {
            calenderModel = new CalenderModel();
            dateText.Text = calenderModel.Now.ToString("F");
            //var test = Instantiate(day);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
