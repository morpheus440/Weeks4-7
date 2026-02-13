using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    float speed = 5f;
    bool isNearNpc = false;
    public Transform NonPlayerCharacter;
    public GameObject Board;
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 position = transform.position;
        Vector3 npcPosition = NonPlayerCharacter.transform.position;

        if(position.x > npcPosition.x - 1f && position.x < npcPosition.x + 1f &&
           position.y > npcPosition.y - 1f && position.y < npcPosition.y + 1f)
        {
            isNearNpc = true;
        }
        else
        {
            isNearNpc = false;
        }
        if(isNearNpc)
        {
            Board.SetActive(true);
        }
        else
        {
            Board.SetActive(false);
        }


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
