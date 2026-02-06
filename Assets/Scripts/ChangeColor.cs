using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void changeColor()
    {
        SpriteRenderer rend = GetComponent<SpriteRenderer>();
        rend.color = Random.ColorHSV();
    }
}
