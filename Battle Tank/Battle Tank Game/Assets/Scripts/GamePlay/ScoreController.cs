using UnityEngine;
using TMPro;
using System;

public class ScoreController : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    private int score = 00;

    private void Awake()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    private void start()
    {
        RefreshUI();
    }

    public void IncreaseScore(int increment)
    {
        score += increment;
        RefreshUI();
    }

    private void RefreshUI()
    {
        scoreText.text = "Score: " + score;
    }
}