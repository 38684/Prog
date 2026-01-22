using UnityEngine;

public class DamageTrap : Collectable
{
    public override void OnCollect()
    {
        Debug.Log("BOOM!!");
    }
}
