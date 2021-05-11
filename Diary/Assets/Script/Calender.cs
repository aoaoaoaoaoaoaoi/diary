using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using View;

namespace Presenter
{
    public class Calender : MonoBehaviour
    {
        [SerializeField] ButtonMonoView day;
        private IReadOnlyCollection<IButtonPrinter> days;

        //TODO:コンフィグファイルに移動
        private const int dayCount = 42;

        // Start is called before the first frame update
        void Start()
        {
            var buttonArray = new IButtonPrinter[dayCount];
            for (int i=0;i<dayCount;++i)
            {
                buttonArray[i] = (Instantiate(day, transform) as IButtonPrinter); 
            }
            days = buttonArray;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
