using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WallSprite : MonoBehaviour
{
    public int index = 0;
    public Sprite[] sprites1;
    public Sprite[] sprites2;
    
    private Sprite[] sprites;
    
    private float counter;

    public int type = 0;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (type == 0) sprites = sprites1;
        else sprites = sprites2;
        
        if (index >= sprites.Length)
        {
            counter = 1f;
            index = 0;
        }

        counter += 0.5f;
        if (index < sprites.Length && counter >= 1)
        {
            GetComponent<SpriteRenderer>().sprite = sprites[index];
            counter = 0;
            index++;
        }
    }

}