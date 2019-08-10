using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GameManagerFive : MonoBehaviour
{
    public int lives;
    public int score;


    public Text UITimer;
    int countDownStartValue = 30;

    public Text livesText;
    public Text scoreText;


    public bool gameOver;
    public bool loadLevel;

    public GameObject gameOverPanel;
    public GameObject loadLevelPanel;
    public int numberOfBricks;



    void Start()
    {
        livesText.text = "Lives: " + lives;
        scoreText.text = "Score: " + score;


        numberOfBricks = GameObject.FindGameObjectsWithTag("brick").Length;
    }


    void Update()
    {

    }


    public void UpdateLives(int changeInLives)
    {
        lives += changeInLives;

        //Check for no lives left and trigger th end of the game
        if (lives < 0 && numberOfBricks > 0)
        {
            lives = 0;

            GameOver();
        }
        livesText.text = "Lives: " + lives;
    }

    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }

    void CountDownTimer()
    {
        if (countDownStartValue > 0)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);
            UITimer.text = "Timer: " + spanTime.Minutes + ":" + spanTime.Seconds;
            countDownStartValue--;
            Invoke("countDownTimer", 1.0f);
        }
        else
        {
            gameOver = true;
        }
    }

    public void UpdateNumberOfBricks()
    {
        numberOfBricks--;
        if (numberOfBricks <= 0)
        {
            numberOfBricks = 0;
            LoadLevel();

        }
    }

    void LoadLevel()
    {
        loadLevel = true;
        loadLevelPanel.SetActive(true);
    }

    void GameOver()
    {
        gameOver = true;
        gameOverPanel.SetActive(true);


    }

    public void Repeat()
    {
        SceneManager.LoadScene("Level 3");
    }

    //Opening the game again
    public void PlayAgain()
    {
        SceneManager.LoadScene("Level 2");
    }
    //Quiting 
    public void Quit()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void TimedOut()
    {
        gameOverPanel.SetActive(true);
        GameOver();
    }

}


