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
        [SerializeField] Text dateText;
        [SerializeField] Button prevButton;
        [SerializeField] Button nextButton;
        [SerializeField] List<Button> dayButtons;

        ICalenderModel calenderModel = CalenderModel.GetInstance();

        // Start is called before the first frame update
        void Start()
        {
            dateText.text = calenderModel.Now.ToString("F");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
