using UnityEngine;
using UnityEngine.Events;

public class TripHookScript : MonoBehaviour
{
    public Adventure Adventurer;
    public UnityEvent EntersHitbox;
    private SpriteRenderer SpriteRenderer;
    void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        bool ifTouches = SpriteRenderer.bounds.Contains(Adventurer.transform.position);

        if (ifTouches)
        {
            EntersHitbox.Invoke();
        }
    }
}
