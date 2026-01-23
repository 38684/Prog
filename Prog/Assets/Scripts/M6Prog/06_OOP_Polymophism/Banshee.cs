using UnityEngine;

public class Banshee : Enemy
{
    private void Start()
    {
        gameObject.name = "Banshee";
    }

    public override void Attack(GameObject target)
    {
        base.Attack(target);
        Debug.Log($"Banshee schreeuwt tegen {target.name}!");
    }

    public override void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log($"Banshee krijgt {damage} damage! HP: {health}");

        if (health <= 10f)
            Debug.Log($"Banshee rent weg!");
    }
}