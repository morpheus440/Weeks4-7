using UnityEngine;
using UnityEngine.UIElements;

public class BearPart : MonoBehaviour
{
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
}


