using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TimeScriptFive : MonoBehaviour
{
    public GameManagerFive gm;
    public BallScriptTwo bs;
    public Text TimerUI;
    int countDownStartValue = 90;
    void Start()
    {
        countDownTimer();
    }

    void countDownTimer()
    {
        if (countDownStartValue > 0)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);
            TimerUI.text = ("Timer: " + spanTime.Minutes + ":" + spanTime.Seconds); ;
            countDownStartValue -= 1;
            Invoke("countDownTimer", 1.0f);

        }
        else if (countDownStartValue <= 0 && gm.numberOfBricks > 0)
        {

            gm.gameOver = true;
            gm.gameOverPanel.SetActive(true);
        }
    }
    void Update()
    {

    }
}

