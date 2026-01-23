using UnityEngine;

public class Zombie : Enemy
{
    private void Start()
    {
        gameObject.name = "Zombie";
    }
    public override void TakeDamage(float damage)
    {
        health -= damage * 0.8f; // Zombies zijn sterker, nemen minder damage
        Debug.Log($"Zombie krijgt {damage * 0.8f} damage! HP: {health}");

        if (health <= 0)
            Die();
    }

    public override void Attack(GameObject target)
    {
        base.Attack(target);
        Debug.Log($"Zombie bijt {target.name}!");
    }
}