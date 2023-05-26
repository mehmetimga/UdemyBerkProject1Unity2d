using System.Collections;
using System.Collections.Generic;
using UdemyBerkProject1.Combats;
using UnityEngine;

namespace UdemyBerkProject1.UIs
{
    public class GameCanvas : MonoBehaviour
    {
        [SerializeField] GameObject gameOverPanel;
        private void Awake()
        {
            gameOverPanel = transform.GetChild(1).gameObject;
        }
        private void Start()
        {
            Dead dead = FindObjectOfType<Dead>();
            dead.OnDead += HandleOnDead;
        }

        private void HandleOnDead()
        {
            gameOverPanel.SetActive(true);
        }
    }
}

