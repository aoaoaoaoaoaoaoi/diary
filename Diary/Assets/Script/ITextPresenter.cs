using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Presenter
{
    public interface ITextPresenter
    {
        string Text { get; set; }
    }
}