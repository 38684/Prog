using UnityEngine;

public class HealthPickup : Collectable
{
    public override void OnCollect()
    {
        Debug.Log("Health restored!");
    }
}
