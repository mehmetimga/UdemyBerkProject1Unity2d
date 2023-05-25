using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UdemyBerkProject1.UIs
{
    public class MenuCanvas : MonoBehaviour
    {
        public void ExitButtonClick()
        {
            Application.Quit();
        }

        public void StartButtonClick()
        {
            GameManager.Instance.StartGame();
        }
    }
}

