﻿
using System;
using TMPro;
using UnityEngine;

namespace DefaultNamespace
{
    public class ScoreManager: MonoBehaviour
    {
        public static ScoreManager Instance { get; set; }
        [SerializeField] private TextMeshProUGUI scoreText;
        public int score { get; set; }

        private void Start()
        {
            Instance = this;
        }

        public void SetScore(int score)
        {
            this.score += score;
            scoreText.text = this.score.ToString();
        }

    }
}