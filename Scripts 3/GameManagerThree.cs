using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerThree : MonoBehaviour
{
    public int lives;
    public int score;

    public Text livesText;
    public Text scoreText;


    public bool gameOver;
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
        if (lives < 0)
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



    public void UpdateNumberOfBricks()
    {
        numberOfBricks--;
        if (numberOfBricks <= 0)
        { 
            loadLevelPanel.SetActive(true);
            gameOver = true;
            Invoke("LoadLevel", 5f);



        }
    }

    void LoadLevel()
    {



        numberOfBricks = GameObject.FindGameObjectsWithTag("brick").Length;
        gameOver = false;
        loadLevelPanel.SetActive(false);
    }

    void GameOver()
    {
        gameOver = true;
        gameOverPanel.SetActive(true);


    }

    public void Repeat()
    {
        SceneManager.LoadScene("Level 4");
    }

    //Opening the game again
    public void PlayAgain()
    {
        SceneManager.LoadScene("Level 3");
    }
    //Quiting 
    public void Quit()
    {
        SceneManager.LoadScene("StartMenu");
    }
}