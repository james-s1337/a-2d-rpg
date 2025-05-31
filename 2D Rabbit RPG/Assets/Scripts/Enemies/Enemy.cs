using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private bool canFloat;
    public Enemy[] party = new Enemy[2]; // For specific encounters that pair up with different types of enemies (max 2 others)
    private Rigidbody2D rb;
    public Vector2 MovementInput { get; set; }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Damage(int amount)
    {
        InitiateCombat(amount);
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = MovementInput * (moveSpeed * Time.deltaTime);
    }

    private void InitiateCombat(int startDamage)
    {
        Debug.Log("Initiating combat with " + gameObject.name);
        // Pause overworld, initiate cutscene
        // Go to battlefield (clear other enemies near player, initiate turn-based combat with player starting attack)
        // If damaged by player first, enemy gets basic attack'd first before starting player's turn
        // If enemy attacks first, player gets damaged first before combat starts
        // Rest is controlled by Battler script
    }

    private void Attack()
    {
        // Play attack animation + movement (if applicable)
    }

    // For attacks that cause movement (like charging attacks)
    private void AnimationMovementTrigger()
    {
        // Use MovementInput as guide for direction
    }

    // Weapon hitbox hits the player, initiating combat
    // Used by both melee and ranged projectiles
    private void WeaponHitTrigger()
    {
        InitiateCombat(-10);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            InitiateCombat(0);
        }
    }
}
