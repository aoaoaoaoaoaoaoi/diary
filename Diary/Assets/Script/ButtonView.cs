using Presenter;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace View
{
    [Serializable]
    public class ButtonView : IButtonPrinter
    {
        [SerializeField] Button button;
        [SerializeField] Text text;

        public void OnClick(Action action)
        {
            button.onClick.AddListener(() => action?.Invoke());
        }

        public void RemoveListener()
        {
            //button.onClick.RemveListener(() => action?.Invoke());
        }

        public string Text
        {
            get => text.text;
            set => text.text = value;
        }
    }
}
