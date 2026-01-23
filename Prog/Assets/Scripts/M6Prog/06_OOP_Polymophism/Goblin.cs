using UnityEngine;

public class Goblin : Enemy
{
    private float evasionChance = 0.2f; // 20% kans om aan te vallen te ontwijken

    private void Start()
    {
        gameObject.name = "Goblin";
    }
    public override void TakeDamage(float damage)
    {
        if (Random.value < evasionChance)
        {
            Debug.Log("Goblin ontwijkt de aanval!");
            return;
        }

        base.TakeDamage(damage); // Gewone damage berekening
    }

    public override void Attack(GameObject target)
    {
        base.Attack(target);
        Debug.Log($"Goblin schiet pijlen af op {target.name}!");
    }
}