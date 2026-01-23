
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected float health = 100f;
    protected float speed = 2f;

    // Virtuele methoden - subklassen kunnen deze overschrijven
    public virtual void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log($"{gameObject.name} krijgt {damage} damage! HP: {health}");

        if (health <= 0)
            Die();
    }

    public virtual void Attack(GameObject target)
    {
        Debug.Log($"{gameObject.name} valt aan!");
    }

    protected virtual void Die()
    {
        Debug.Log($"{gameObject.name} is dood!");
        Destroy(gameObject);
    }
}
