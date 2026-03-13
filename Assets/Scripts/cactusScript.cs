using UnityEngine;
using UnityEngine.Events;

public class cactusScript : MonoBehaviour
{
    public GameObject player;
    public EventDrivenLara playerThing;
    public UnityEvent OnEnter;
    public UnityEvent OnLeave;

    private SpriteRenderer hazardRenderer;
    private bool wasInTheHazard = false;


    void Start()
    {
        hazardRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        bool isInTheHazard = hazardRenderer.bounds.Contains(player.transform.position);
        if (isInTheHazard
            && wasInTheHazard == false)
        {
            wasInTheHazard = true;
            Debug.Log("Player entered the hazard");
        }
        else if (!isInTheHazard && wasInTheHazard)
        {
            wasInTheHazard = false;
            Debug.Log("Player left the hazard");
        }
        if (isInTheHazard)
        {
            playerThing = GetComponent<EventDrivenLara>();
        }
        else
        {

        }
    }
}