using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UdemyBerkProject1.UIs
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesButtonClick()
        {
            GameManager.Instance.RestartGame();
        }
        public void NoButtonClick()
        {

        }
    }
}

