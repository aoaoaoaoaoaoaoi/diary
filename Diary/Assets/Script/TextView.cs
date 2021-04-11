using Presenter;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace View
{
    [Serializable]
    public class TextView : MonoBehaviour, ITextPrinter
    {
        [SerializeField] Text text;

        public string Text
        {
            get => text.text;
            set => text.text = value;
        }
    }
}
