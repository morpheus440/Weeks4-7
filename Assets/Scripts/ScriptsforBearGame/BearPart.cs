using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BearPart : MonoBehaviour
{
    SpriteRenderer mySpriteRenderer;
    public float smallSize;
    public float largeSize;
    public Color darkColour;
    public Color lightColour;
    public float transformValue;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 position = transform.position;
        position.y = transformValue;
        transform.position = position;
    }

    public void setTransform(float temp)
    {
        transformValue = temp;
    }

    public void SetColor(bool colorChoice)
    {
        if(colorChoice == true)
        {
            mySpriteRenderer.color = darkColour;
        }
        else
        {
            mySpriteRenderer.color = lightColour;
        }
    }

    public void SetSize(bool bigOrSmall)
    {
        if(bigOrSmall == true)
        {
            transform.localScale = new Vector3(smallSize, smallSize, 1);
        }
        else
        {
            transform.localScale = new Vector3(largeSize, largeSize, 1);
        }
    }
}


