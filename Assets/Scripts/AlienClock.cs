using UnityEngine;
using UnityEngine.UI;

public class AlienClock : MonoBehaviour
{
    public Slider AlienSlier;
    public float clockDuration;
    private float timeWaiting = 0f;
    public GameObject warperObject;
    void Start()
    {
      AlienSlier.maxValue = clockDuration;
    }

    void Update()
    {
        timeWaiting += Time.deltaTime * 1;
        AlienSlier.value = timeWaiting;

        if (timeWaiting > clockDuration)
            {
            timeWaiting = 0f;
            Debug.Log("Alien Clock has finished counting down.");
            //Destroy(gameObject);

            //when timer is up
            //EITHER:
            //turn the warper object off when it is on
            //turn the waepr object on when it is off
            bool shouldTurnOn = warperObject.activeInHierarchy;
            bool shouldTurnOff = !warperObject.activeInHierarchy;
            if (shouldTurnOn)
            {
                warperObject.SetActive(true);
            }
            if (shouldTurnOff)
            {
                warperObject.SetActive(false);
            }

        }
    }
}
