using UnityEngine;

public class Capsule : MonoBehaviour
{
    float moveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position.x += moveSpeed * Time.deltaTime;
        transform.position = position;
    }
    public void OnMoveClick()
    {
        moveSpeed = 1;
    }
    public void OnStopClick()
    {
        moveSpeed = 0;
    }
    public void OnFlipClick()
    {
        moveSpeed = -1;

    }
}
