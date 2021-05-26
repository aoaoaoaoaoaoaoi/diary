using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Extension
{
    public static class ButtonExtension
    {
        private static Dictionary<Button, List<UnityAction>> buttonActions;

        public static void OnClick(this Button button, UnityAction action)
        {
            if(buttonActions == null)
            {
                buttonActions = new Dictionary<Button, List<UnityAction>>();
            }
            if (buttonActions.TryGetValue(button, out List<UnityAction> actions))
            {
                actions.Add(action);
            }
            else
            {
                buttonActions.Add(button, new List<UnityAction> { action });
            }
            //button.gameObject.OnDestroy = () => ;
            button.onClick.AddListener(action);
        }

        public static void DeleteAllListener(this Button button)
        {
        }
    }
}
