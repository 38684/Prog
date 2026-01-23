using UnityEngine;

public class Werewolf : Enemy
{
    private void Start()
    {
        gameObject.name = "Werewolf";
    }
    public override void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log($"Werewolf krijgt {damage} damage en word bozer! HP: {health}");

        if (health <= 0)
            Die();
    }

    public override void Attack(GameObject target)
    {
        base.Attack(target);
        
        if (health < 50f)
            Debug.Log($"Werewolf bijt {target.name} hard!");
        else
            Debug.Log($"Werewolf bijt {target.name}!");
    }
}