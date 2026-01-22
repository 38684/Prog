
using System;
using UnityEngine;

public abstract class Collectable : MonoBehaviour
{
    public static event Action <GameObject> OnCollectable;

    public abstract void OnCollect();

    private void OnTriggerEnter(Collider other)
    {
        OnCollect();
        OnCollectable.Invoke(gameObject);
        Destroy(gameObject);
    }
}
