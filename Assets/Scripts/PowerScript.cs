using UnityEngine;

public class PowerScript : MonoBehaviour
{
    void Update()
    {
        
    }

    public void setGameObjectTorF(float isOn)
    {
        if (isOn == 1)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
