using UnityEngine;

public class Minotaur : Enemy
{
    bool strongAttack = false;

    private void Start()
    {
        gameObject.name = "Minotaur";
    }

    public override void Attack(GameObject target)
    {
        base.Attack(target);

        if (strongAttack)
            Debug.Log($"Minotaur slaat {target.name}!");
        else
            Debug.Log($"Minotaur slaat {target.name} hard!");

        strongAttack = !strongAttack;
    }
}