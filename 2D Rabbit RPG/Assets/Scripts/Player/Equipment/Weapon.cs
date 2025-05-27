using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Where statistics and communication between weap and player take place
    // Animation control and hitbox control will be managed in the sprite obj
    private Player player;
    public float velocity { get; private set; } // How much the player moves during the attack
    // private WeaponStats weapStats;
    private Animator anim;
    private bool canDamage;

    private void Awake()
    {
        player = GetComponentInParent<Player>();
        anim = GetComponent<Animator>();
        velocity = 4.0f;
    }

    public void EnterWeap()
    {
        // Make sprite visible
        gameObject.SetActive(true);
        anim.SetBool("attacking", true);
    }

    public void ExitWeap()
    {
        // Make sprite invisible
        gameObject.SetActive(false);
        anim.SetBool("attacking", false);
    }

    public void OnAnimationTrigger()
    {
        player.AnimationTrigger();
    }

    public void OnAnimationFinishTrigger()
    {
        player.AnimationFinishTrigger();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            return;
        }

        IDamageable damageable = collision.GetComponent<IDamageable>();
        // Check if item has an IDamageable interface (first find if interactable script exists)
        if (damageable != null)
        {
            damageable.Damage(1); // Temp value for now
        }
    }
}
