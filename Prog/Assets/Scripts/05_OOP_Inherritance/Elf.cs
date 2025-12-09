using System.Collections;
using UnityEngine;

public class Elf : EnemyParent
{
    private void Start()
    {
        health = 3;
        speed = 2f;
        StartCoroutine(ToggleVisibility());
    }

    IEnumerator ToggleVisibility()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            GetComponent<MeshRenderer>().enabled = false;
            yield return new WaitForSeconds(0.5f);
            GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
