using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BearPart : MonoBehaviour
{

    public float smallSize;
    public float largeSize;
    public Color darkColour;
    public Color lightColour;
    public Color black;
    public float transformValue;

    void Start()
    {
        //SetXPos(0);
    }

    void Update()
    {
        Vector3 position = transform.position;
        position.y = transformValue;
        transform.position = position;
    }

    public void setTransform(float temp)
    {
        transformValue = -temp * 10 + 5;
    }

    public void SetColor(float colorChoice, GameObject temp)
    {
        if (colorChoice == 1)
        {
            SpriteRenderer spawnedRenderer = temp.GetComponent<SpriteRenderer>();
            spawnedRenderer.color = darkColour;
        }
        if(colorChoice == 2)
        {
            SpriteRenderer spawnedRenderer = temp.GetComponent<SpriteRenderer>();
            spawnedRenderer.color = lightColour;
        }
        if (colorChoice == 3)
        {
            SpriteRenderer spawnedRenderer = temp.GetComponent<SpriteRenderer>();
            spawnedRenderer.color = black;
        }
    }

    public void SetSize(float bigOrSmall, GameObject temp)
    {
        if(bigOrSmall == 1)
        {
            transform.localScale = new Vector3(smallSize, smallSize, 1);
        }
        if (bigOrSmall == 2)
        {
            transform.localScale = new Vector3(smallSize+0.25f, smallSize+ 0.25f, 1);
        }
        if (bigOrSmall == 3)
        {
            transform.localScale = new Vector3(largeSize, largeSize, 1);
        }
        if (bigOrSmall == 4)
        {
            transform.localScale = new Vector3(largeSize+ 0.5f, largeSize+ 0.5f, 1);
        }
        if (bigOrSmall == 5)
        {
            transform.localScale = new Vector3(largeSize + 1.25f, largeSize + 1.25f, 1);
        }
        if (bigOrSmall == 6)
        {
            transform.localScale = new Vector3(largeSize + 1.75f, largeSize + 2.25f, 1);
        }
        if (bigOrSmall == 7)
        {
            transform.localScale = new Vector3(largeSize, largeSize, 1);
        }
        if (bigOrSmall == 8)
        {
            transform.localScale = new Vector3(largeSize, largeSize + 0.25f, 1);
        }
        if (bigOrSmall == 9)
        {
            transform.localScale = new Vector3(smallSize - 1f, smallSize - 1f, 1);
        }
    }

    public void SetXPos(float xPos)
    {
        Vector3 position = transform.position;
        position.x = xPos;
        transform.position = position;
    }
    

}


