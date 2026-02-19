using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotationOne = transform.eulerAngles;
        rotationOne.z += speed * Time.deltaTime;
        transform.eulerAngles = rotationOne;

    }
}
