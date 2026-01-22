using UnityEngine;

public class CoinPickup : Collectable
{
    public override void OnCollect()
    {
        Debug.Log("Coin collected!");
    }
}
