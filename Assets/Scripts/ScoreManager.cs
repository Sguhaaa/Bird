
using System;
using TMPro;
using UnityEngine;

namespace DefaultNamespace
{
    public class ScoreManager: MonoBehaviour
    {
        public static ScoreManager Instance { get; set; }
        [SerializeField] private TextMeshProUGUI scoreText;
        public int Score { get; set; }

        private void Start()
        {
            Instance = this;
        }

        public void SetScore(int score)
        {
            Score += score;
            scoreText.text = Score.ToString();
        }

    }
}