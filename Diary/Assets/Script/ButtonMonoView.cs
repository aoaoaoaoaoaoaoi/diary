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

        public void SetActive()
        {
            button.gameObject.SetActive(true);
        }

        public void SetInActive()
        {
            button.gameObject.SetActive(false);
        }
    }
}
