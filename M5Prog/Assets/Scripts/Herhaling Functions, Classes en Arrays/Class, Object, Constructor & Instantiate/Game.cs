using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private GameObject towerPrefab;
    [SerializeField] private Vector2 groundSize;

    void Start()
    {
        Plane jumbo = new Plane(400);
        Plane player = new Plane();
        List<Plane> fleet = new List<Plane>();

        for (int i = 0; i < 500; i++)
        {
            fleet.Add(new Plane());
        }
    }

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

public class Plane
{
    int capacity;
    int speed;
    public void TakeOff(Transform transform)
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }

    public Plane(int passCap = 0, int newSpeed = 5)
    {
        capacity = passCap;
        speed = newSpeed;
        Debug.Log("Hallo ik ben een nieuw vliegtuig! waar " + capacity + " mensen in kunnen.");
    }
}
