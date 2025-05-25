using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Where statistics and communication between weap and player take place
    // Animation control and hitbox control will be managed in the sprite obj
    private Player player;
    public float velocity { get; private set; } // How much the player moves during the attack
    // private WeaponStats weapStats;
    private SpriteRenderer weapSprite;

    private void Awake()
    {
        player = GetComponentInParent<Player>();
        weapSprite = GetComponent<SpriteRenderer>();
        velocity = 4.0f;
    }

    public void EnterWeap()
    {
        // Make sprite visible
        gameObject.SetActive(true);
    }

    public void ExitWeap()
    {
        // Make sprite invisible
        gameObject.SetActive(false);
    }
}
