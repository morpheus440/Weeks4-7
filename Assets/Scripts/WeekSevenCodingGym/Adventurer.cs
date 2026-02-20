using UnityEngine;

public class Adventure : MonoBehaviour
{
    public float health = 100f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TakeDamage(float damageAmount)
    {
        health -= damageAmount;
        Debug.Log("Player takes " + damageAmount + " damage! Current health: " + health);
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
