﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFive : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool inPlay;
    public Transform paddle;
    public float speed;
    public Transform explosion;
    public GameManagerFive gm;

    public Joystick joy;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
      
    }


    void Update()
    {
        if (gm.gameOver)
        {
            return;
        }

        if (!inPlay)
        {
            transform.position = paddle.position;    //Ball to paddle
        }

        float verticalMove = joy.Vertical;

        if (verticalMove > .5f && !inPlay)
        {
            inPlay = true;
            rb.AddForce(Vector2.up * speed);  //Moving the ball up
        }
        if (verticalMove > .5f && inPlay)
        {

            transform.position = paddle.position;    //Changing the ball position
        }


    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("bottom"))
        {

            rb.velocity = Vector2.zero;
            inPlay = false;
            gm.UpdateLives(-1);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("brick"))
        {
            BricksFive brickScript = other.gameObject.GetComponent<BricksFive>();
            if (brickScript.hitsToBreak > 1)
            {
                brickScript.BreakBrick();
            }
            else
            {
                Transform newExplosion = Instantiate(explosion, other.transform.position, other.transform.rotation);
                Destroy(newExplosion.gameObject, 1.5f);

                gm.UpdateScore(brickScript.points);
                gm.UpdateNumberOfBricks();

                Destroy(other.gameObject);
            }
          
        }
    }
}




