using System.Collections.Generic;
using UnityEngine;

public class ScriptToSpawn : MonoBehaviour
{
   public GameObject spawnBearPart;
   float bearPartsSpawned;

    private List<GameObject> spawnedParts = new List<GameObject>();

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void bearPartList()
    {
        
    }

    public void spawnBearPartMethod()
    {
        Instantiate(spawnBearPart, transform.position, Quaternion.identity);
    }
}
