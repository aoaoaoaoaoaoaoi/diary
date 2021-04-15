using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Presenter
{
    public interface IButtonPrinter : ITextPrinter
    {
        void OnClick(Action action);
    }
}
