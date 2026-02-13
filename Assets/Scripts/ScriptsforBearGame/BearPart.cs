using UnityEngine;
using UnityEngine.UIElements;

public class BearPart : MonoBehaviour
{
    public bool movingUp;
    public bool movingLeft;
    public bool movingDown;
    public bool movingRight;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 position = transform.position;
        if(movingUp)
        {
            position.y += 0.1f;
        }
        if (movingRight)
        {
            position.x += 0.1f;
        }
        if (movingDown)
        {
            position.y -= 0.1f;
        }
        if (movingLeft)
        {
            position.x -= 0.1f;
        }

        transform.position = position;
    }

    public void buttonWasPressed()
    {

    }

    void moveTeddy(int direction)
    {
        Vector3 position = transform.position;
        if(direction == 1)
        {
            movingUp = true;
        }
        if (direction == 2)
        {
            movingRight = true;
        }
        if (direction == 3)
        {
            movingDown = true;
        }
        if (direction == 4)
        {
            movingLeft = true;
        }
    }

    public void makeBearList()
    {

    }
}


