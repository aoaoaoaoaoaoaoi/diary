using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Model;

namespace Presenter
{
    public class CalenderPresenter : MonoBehaviour
    {
        [SerializeReference, SubclassSelector] ITextPrinter dateText;
        [SerializeReference, SubclassSelector] IButtonPrinter prevButton;
        [SerializeField] Button nextButton;
        [SerializeField] List<Button> dayButtons;

        ICalenderModel calenderModel;

        // Start is called before the first frame update
        void Start()
        {
            calenderModel = new CalenderModel();
            dateText.Text = calenderModel.Now.ToString("F");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
