using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BearPart : MonoBehaviour
{

    public float smallSize;//made a large and small size so I make changes within unity
    public float largeSize;
    public Color darkColour;//made 3 colours so I can change the colour of the bear part within unity
    public Color lightColour;
    public Color black;
    public float transformValue;

    void Update()
    {
        Vector3 position = transform.position;//Changes the position of the bear part based on the value of transformValue which is set in the script to spawn
        position.y = transformValue;
        transform.position = position;
    }

    public void setTransform(float temp)//sets the transform value based on the value of temp which is set in the script to spawn
    {
        transformValue = -temp * 10 + 5;
    }

    public void SetColor(float colorChoice, GameObject temp)//changes color of the bear part 
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

    public void SetSize(float bigOrSmall, GameObject temp)//changes the size of the bear parts
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

    public void SetXPos(float xPos)//set x pos
    {
        Vector3 position = transform.position;
        position.x = xPos;
        transform.position = position;
    }
    

}


