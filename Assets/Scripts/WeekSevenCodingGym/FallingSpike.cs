using UnityEngine;
using UnityEngine.Events;

public class FallingSpike : MonoBehaviour
{
    public Adventure Adventurer;
    private SpriteRenderer SpriteRenderer;
    public UnityEvent EntersHitbox;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool ifTouches = SpriteRenderer.bounds.Contains(Adventurer.transform.position);

        if (ifTouches)
        {
            EntersHitbox.Invoke();
            Destroy(gameObject);
        }
    }

    public void Fall()
    {
        Vector3 newPosition = transform.position;
        newPosition.y -= 0.1f;
        transform.position = newPosition;
    }
}
