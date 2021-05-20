using Presenter;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace View
{
    [Serializable]
    public class ButtonMonoView : MonoBehaviour, IButtonMonoPrinter
    {
        [SerializeField] Button button;
        [SerializeField] Image buttonImage;
        [SerializeField] Text text;

        public void OnClick(Action action)
        {
            button.onClick.AddListener(() => action?.Invoke());
        }

        public string Text
        {
            get => text.text;
            set => text.text = value;
        }

        public void SetInEnable()
        {
            text.enabled = false;
            button.enabled = false;
            buttonImage.enabled = false;
        }

        public void SetEnable()
        {
            text.enabled = true;
            button.enabled = true;
            buttonImage.enabled = true;
        }
    }
}
