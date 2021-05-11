using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using View;

namespace Presenter
{
    //TODO�F�C���^�[�t�F�[�X���瑀��ł���悤�ɂ���
    public class Calender : MonoBehaviour
    {
        [SerializeField] ButtonMonoView day;
        private IReadOnlyCollection<IButtonPrinter> days;

        //TODO:�R���t�B�O�t�@�C���Ɉړ�
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

        //�j�����󂯎���ď��Ԃɔԍ���U��
        public void RefreshDays()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
