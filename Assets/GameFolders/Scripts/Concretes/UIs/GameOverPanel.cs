using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UdemyBerkProject1.UIs
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesButtonClick()
        {
            GameManager.Instance.StartGame();
        }
        public void NoButtonClick()
        {
            GameManager.Instance.ReturnMenu();
        }
    }
}

