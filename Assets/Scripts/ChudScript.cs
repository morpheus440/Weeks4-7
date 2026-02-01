using UnityEngine;

public class ChudScript : MonoBehaviour
{
    public float speed = 5f;
    void Update()
    {
        float temp = transform.eulerAngles.z;
        transform.Rotate(speed * temp * Time.deltaTime, 0, 0);
        //transform.eulerAngles = new Vector3(speed * Time.deltaTime, 0, 0);
        //Quaternion.Euler(speed * Time.deltaTime, 0, 0);
    }
}
