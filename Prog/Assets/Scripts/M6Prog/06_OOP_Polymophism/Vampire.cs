using UnityEngine;

public class Vampire : Enemy
{
    private void Start()
    {
        gameObject.name = "Vampire";
    }

    public override void Attack(GameObject target)
    {
        base.Attack(target);
        health += 25f;

        Debug.Log($"Vampire bijt {target.name} en healed 25 HP! HP:{health}");
    }
}