using JetBrains.Annotations;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawningPrefab;
    public float waitDuration;
    public float destroyDuration;
    public Color pacerColour;

    private float waitProgress = 0f;
    private float destroyProgress = 0f;
    public float pacerSpeed;

    public 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //EMpTY VECTOR3
        //Vector3 originPosition = Vector3.zero;S
        //Instantiate(spawningPrefab, transform.position, transform.rotation);
        //s[awmomg from spawmer

        //Instantiate(spawningPrefab, transform.position, Quaternion.identity );


        //origonaly 
        //Instantiate(spawningPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        waitProgress += Time.deltaTime;
        if (waitProgress > waitDuration)
            {
            GameObject spawnedObject = Instantiate(spawningPrefab, transform.position, Quaternion.identity);

            //Typeofcomponent variableName = variableOfObject.GetComponent<Typeofcomponent>();


            Pacer spawnPacer = spawnedObject.GetComponent<Pacer>();
            spawnPacer.speed = pacerSpeed;

            SpriteRenderer spawnedRenderer = spawnedObject.GetComponent<SpriteRenderer>();
            spawnedRenderer.color = pacerColour;

            //Destroy(spawnedObject, destroyDuration);


            waitProgress = 0f;

        
        }
        
    }
    public void IncreasePacerSpeed(float amount)
    {
        pacerSpeed += amount;
    }
}
