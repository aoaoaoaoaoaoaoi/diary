using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalenderPresenter : MonoBehaviour
{
    [SerializeField] Text dateText;
    [SerializeField] Button prevButton;
    [SerializeField] Button nextButton;
    [SerializeField] List<Button> dayButtons;
   
    // Start is called before the first frame update
    void Start()
    {
        var now = new DateTime().Date;
        //dateText
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
