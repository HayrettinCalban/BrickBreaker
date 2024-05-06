using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text livesText;

    public int score;
    public int lives;

    public bool gameOver;

    public void increaseScore()
    {
        score++;
        scoreText.text = score.ToString("score:0");
    }
    public void decreaseLive()
    {
        lives--;
        if (lives<=0)
        {
            lives = 0;
            GameOver();
        }
        livesText.text = lives.ToString();
    }
    void GameOver()
    {
        gameOver=true;
    }
}