using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScriptToSpawn : MonoBehaviour
{
    public GameObject spawnBearPart;
    public BearPart bearPartScript;

    void Start()
    {
        spawnBearPartMethod();
    }
    
    void Update()
    {
     
    }

    public void spawnBearPartMethod()
    {
        Vector3 spawnPosition = new Vector3(1, 1, 0);
        GameObject newBearPart = Instantiate(spawnBearPart, spawnPosition, Quaternion.identity);
        bearPartScript = newBearPart.GetComponent<BearPart>();
        bearPartScript.SetColor(true, newBearPart);
        

    }
    public void setTransform(float temp)
    {
        bearPartScript.setTransform(temp);
    }

}
