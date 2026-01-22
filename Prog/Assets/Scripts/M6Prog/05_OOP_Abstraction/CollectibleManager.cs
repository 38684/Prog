using System.Collections.Generic;
using UnityEngine;

public class CollectibleManager : MonoBehaviour
{
    List<GameObject> collectables = new List<GameObject>();

    private void Collected(GameObject gameObject)
    {
        collectables.Remove(gameObject);
        Debug.Log("Collectible collected! Remaining: " + collectables.Count);
    }

    private void Start()
    {
        foreach (Collectable collectable in FindObjectsByType<Collectable>(FindObjectsSortMode.None))
        {
            collectables.Add(collectable.gameObject);
        }

        Debug.Log("Total collectibles: " + collectables.Count);
        Collectable.OnCollectable += Collected;
    }
}
