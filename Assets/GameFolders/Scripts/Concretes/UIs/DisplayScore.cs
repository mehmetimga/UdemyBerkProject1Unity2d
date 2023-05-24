using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyBerkProject1.UIs
{
    public class DisplayScore : MonoBehaviour
    {
        TMPro.TextMeshProUGUI _scoreText;

        private void Awake()
        {
            _scoreText = GetComponent<TMPro.TextMeshProUGUI>();
        }
        private void Start()
        {
            GameManager.Instance.OnScoreChanged += HandleOnScoreChanged;
            HandleOnScoreChanged();
        }
        private void OnDisable()
        {
            GameManager.Instance.OnScoreChanged -= HandleOnScoreChanged;

        }
        public void HandleOnScoreChanged(int score = 0)
        {
            _scoreText.text = $"Score:{score}";
        }    
    }
}

