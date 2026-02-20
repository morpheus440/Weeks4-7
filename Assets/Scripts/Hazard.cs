using UnityEngine;

public class DamageHazard : MonoBehaviour
{
    public Color damageColor;
    private Color playerColor;
    public int damage;
    public DungeonRaiderPlayer player;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ApplyDamage()
    {
        player.TakeDamage(damage);
    }

    public void ChangePlayerColour()
    {
        SpriteRenderer playerRednerer = player.GetComponent<SpriteRenderer>();
        playerColor = playerRednerer.color;
        playerRednerer.color = damageColor;
    }
}