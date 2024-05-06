using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text livesText;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private Image gameOverImage;
    public int score;
    public int lives;

    public bool gameOver;
    private void Start()
    {
        livesText.text = lives.ToString("Lives=0");
        scoreText.text = score.ToString("score:0");
        gameOverPanel.transform.localScale = Vector3.zero;
    }
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
        livesText.text = lives.ToString("Lives=0");
    }
    void GameOver()
    {
        gameOver=true;
        gameOverPanel.transform.localScale = Vector3.one;
        gameOverImage.transform.localScale = Vector3.one;
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    }