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
        ITextPrinter dateText;
        [SerializeField] Button prevButton;
        [SerializeField] Button nextButton;
        [SerializeField] List<Button> dayButtons;

        ICalenderModel calenderModel;

        // Start is called before the first frame update
        void Start()
        {
            dateText = GetComponent<ITextPrinter>();
            Debug.Log(dateText);

            dateText.Text = calenderModel.Now.ToString("F");

            calenderModel = new CalenderModel();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
