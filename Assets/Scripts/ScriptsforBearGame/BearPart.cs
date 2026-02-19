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
    public float transformValue;

    void Start()
    {
        SetXPos(0);
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

    public void SetColor(bool colorChoice, GameObject temp)
    {
        if (colorChoice == true)
        {
            SpriteRenderer spawnedRenderer = temp.GetComponent<SpriteRenderer>();
            spawnedRenderer.color = darkColour;
        }
        if(colorChoice == false)
        {
            SpriteRenderer spawnedRenderer = temp.GetComponent<SpriteRenderer>();
            spawnedRenderer.color = darkColour;
        }
    }

    public void SetSize(bool bigOrSmall)
    {
        if(bigOrSmall == true)
        {
            transform.localScale = new Vector3(smallSize, smallSize, 1);
        }
        if(bigOrSmall == false)
        {
            transform.localScale = new Vector3(largeSize, largeSize, 1);
        }
    }

    public void SetXPos(float xPos)
    {
        Vector3 position = transform.position;
        position.x = xPos;
        transform.position = position;
    }
    

}


