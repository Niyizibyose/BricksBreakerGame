using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickFour : MonoBehaviour
{
   
    public int points;
    public int hitsToBreak;
    public Sprite hitSprite;

 
    public void BreakBrick()
    {
        hitsToBreak--;
        GetComponent<SpriteRenderer>().sprite = hitSprite;
    }
}

