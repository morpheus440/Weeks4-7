using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    float speed = 5f;
    void Start()
    {
        
    }

    void Update()
    {
        bool leftPressed = Keyboard.current.aKey.isPressed;
        bool rightPressed = Keyboard.current.dKey.isPressed;
        bool upPressed = Keyboard.current.wKey.isPressed;
        bool downPressed = Keyboard.current.sKey.isPressed;
        if(leftPressed)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if(rightPressed)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if(upPressed)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if(downPressed)
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
    }
}
