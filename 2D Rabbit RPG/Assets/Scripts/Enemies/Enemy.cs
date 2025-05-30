using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private bool canFloat;
    public void Damage(int amount)
    {
        Debug.Log("Initiating combat with " + gameObject.name);
    }
}
