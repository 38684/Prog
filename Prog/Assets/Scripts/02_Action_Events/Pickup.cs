using System;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public static event Action<int> PointPickup;
    [SerializeField] int points; 

    private void OnTriggerEnter(Collider other)
    {
        PointPickup.Invoke(points);
        Destroy(gameObject);
    }
}
