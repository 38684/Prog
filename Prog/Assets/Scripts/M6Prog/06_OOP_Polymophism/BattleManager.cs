
using System.Collections.Generic;
using UnityEngine;
public class BattleManager : MonoBehaviour
{
    [SerializeField] private List<Enemy> enemies;

    void Start()
    {
        // Maak verschillende enemy types
        enemies = new List<Enemy>
        {
            new GameObject().AddComponent<Zombie>(),
            new GameObject().AddComponent<Goblin>(),
            new GameObject().AddComponent<Dragon>(),
            new GameObject().AddComponent<Phoenix>(),
            new GameObject().AddComponent<Vampire>(),
            new GameObject().AddComponent<Minotaur>(),
            new GameObject().AddComponent<Banshee>(),
            new GameObject().AddComponent<Troll>(),
            new GameObject().AddComponent<Werewolf>()
        };
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("PRESSED - SPACE");
            // POLYMORFISME! We behandelen alle enemies hetzelfde,
            // maar elke enemy voert zijn eigen Attack() uit
            foreach (Enemy enemy in enemies)
            {
                enemy.Attack(gameObject); // Verschillende implementaties!
            }   
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("PRESSED - D");
            // Alle enemies nemen damage, maar elk op zijn eigen manier
            foreach (Enemy enemy in enemies)
            {
                if (enemy == null)
                {
                    enemies.Remove(enemy);
                    break;
                }
                enemy.TakeDamage(25f); // Zombies nemen minder, Goblins ontwijken misschien
            }
        }
    }
}