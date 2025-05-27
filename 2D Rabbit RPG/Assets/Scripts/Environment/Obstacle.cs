using UnityEngine;

// Stuff like boxes in the way, cobwebs etc.
public class Obstacle : MonoBehaviour, IDamageable
{
    [SerializeField] private int hitPoints;

    public void Damage(int amount)
    {
        hitPoints -= amount;

        if (hitPoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
