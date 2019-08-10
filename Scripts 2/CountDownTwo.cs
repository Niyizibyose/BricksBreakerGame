using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CountDownTwo : MonoBehaviour
{
    

    public float startingTime;
    public float totalTime;
    public Text text;

    private float minutes;
    private float seconds;
    [Header("--Event Timer--")]
    public bool useEventTimer;
    public UnityEvent TimerEvent;

    public void Start()
    {
        startingTime = totalTime;
    }
    private void Update()
    {
        totalTime -= Time.deltaTime;
        minutes = (int)(totalTime / 60);
        seconds = (int)(totalTime % 60);
        if (useEventTimer)
        {
            if (minutes < 0 && seconds < 0)
            {
                totalTime = 0;
                useEventTimer = true;
                
            
               
            }
        }
        text.text = minutes.ToString() + ":" + seconds.ToString();

    }

}

