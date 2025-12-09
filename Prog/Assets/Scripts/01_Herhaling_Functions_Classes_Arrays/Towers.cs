
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private GameObject towerPrefab;
    [SerializeField] private Vector2 groundSize;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var randomRangeX = Random.Range(-groundSize.x / 2, groundSize.x / 2);
            var randomRangeY = Random.Range(-groundSize.y / 2, groundSize.y / 2);
            var randomScale = Random.Range(0.1f, 1f);
            var towerPosition = new Vector3(randomRangeX, randomScale, randomRangeY);
            
            var spawnedTower = Instantiate(towerPrefab, towerPosition, new Quaternion(0,0,0,0));
            spawnedTower.transform.localScale = Vector3.one * randomScale;
        }
    }
}
