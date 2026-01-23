using UnityEngine;

public class Troll : Enemy
{
    private void Start()
    {
        gameObject.name = "Troll";
    }

    public override void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log($"Troll krijgt {damage} damage! HP: {health}");

        health += 25f;
        Debug.Log($"Troll healed {25} damage! HP: {health}");

        if (health <= 0)
            Die();
    }
}