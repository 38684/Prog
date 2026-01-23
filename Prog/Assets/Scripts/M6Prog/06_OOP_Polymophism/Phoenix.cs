using UnityEngine;

public class Phoenix : Enemy
{
    private void Start()
    {
        gameObject.name = "Phoenix";
    }
    public override void TakeDamage(float damage)
    {
        health -= damage; // Zombies zijn sterker, nemen minder damage
        Debug.Log($"Phoenix krijgt {damage} damage! HP: {health}");

        health += 25f;
        Debug.Log($"Phoenix healed {25} damage! HP: {health}");

        if (health <= 0)
            Die();
    }

    public override void Attack(GameObject target)
    {
        base.Attack(target);
        Debug.Log($"Phoenix spuwt vuur en verkoolt {target.name}!");
    }
}