using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BricksLevelOne : MonoBehaviour
{

    public int points;
    public int hitsToBreak;
    public Sprite hitSprite;


    //Making strong bricks 
    public void BreakBrick()
    {
        hitsToBreak--;
        GetComponent<SpriteRenderer>().sprite = hitSprite;
    }
}

