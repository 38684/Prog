
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    List<GameObject> enemyList = new List<GameObject>();

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            for (int i = 0; i < 100; i++)
            {
                enemyList.Add(Instantiate(enemyPrefab, transform));
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            while (enemyList.Count > 0)
            {
                Destroy(enemyList[0]);
                enemyList.RemoveAt(0);
            }
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            StartCoroutine(DestroyEnemies(enemyList));
        }
    }

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            for (int i = 0; i < 3; i++)
            {
                enemyList.Add(Instantiate(enemyPrefab, transform));
            }
            yield return new WaitForSeconds(3);
        }
    }

    IEnumerator DestroyEnemies(List<GameObject> enemyList)
    {
        while (enemyList.Count > 0)
        {
            Destroy(enemyList[0]);
            enemyList.RemoveAt(0);
            yield return new WaitForSeconds(0.01f);
        }

        yield break;
    }
}
