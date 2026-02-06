using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class Warper : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        //if we click and not over UI
        bool shouldWarp = Mouse.current.leftButton.wasPressedThisFrame && 
                            !EventSystem.current.IsPointerOverGameObject();

        if (shouldWarp == true)
        {
            Vector3 currentMousePosition = Mouse.current.position.ReadValue();
            transform.position = currentMousePosition;
        }
    }
}
