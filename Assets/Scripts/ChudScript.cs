using UnityEngine;

public class ChudScript : MonoBehaviour
{
    public float speed = 5f;
    void Start()
    {
        
    }
    void Update()
    {
        Vector3 rotationPosition = transform.eulerAngles;
        rotationPosition.z += speed * Time.deltaTime;
        transform.eulerAngles = rotationPosition;
    }
    public void setSpin(float speedOfSpin)
    {
        speed = speedOfSpin;
    }
    public void StopSpin(float speedOfSpin)
    {
        speed = speedOfSpin;
    }
}
