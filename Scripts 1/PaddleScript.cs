﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    public float speed;
    public float rightScreenEdge;
    public float leftScreenEdge;
    public GameManager gm;

    public Joystick joy;

    void Start()
    {

    }

    void Update()
    {
        if (gm.gameOver)
        {
            return;
        }
        float horizontal = joy.Horizontal;
       
        if (horizontal <= .2f )
        {
            transform.Translate(Vector2.right * horizontal * Time.deltaTime * speed);

        } else if (horizontal >=0.2f){
            transform.Translate(Vector2.right * horizontal * Time.deltaTime * speed);
        }

        if (transform.position.x < leftScreenEdge)
        {
            transform.position = new Vector2(leftScreenEdge, transform.position.y);
        }

        if (transform.position.x > rightScreenEdge)
        {
            transform.position = new Vector2(rightScreenEdge, transform.position.y);
        }
    }
}





