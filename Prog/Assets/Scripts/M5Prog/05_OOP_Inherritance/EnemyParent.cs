
using Unity.VisualScripting;
using UnityEngine;

public class EnemyParent : MonoBehaviour
{
    bool isDead;
    public int health;
    public float speed;
    
    private void FixedUpdate()
    {
        if (isDead) return;

        transform.Translate(Vector3.right * Time.deltaTime * speed, Space.World);
    }

    public void LoseHealth(int damage)
    {
        health -= damage;

        if (health < 1)
        {
            Death();
        }
    }

    public void Death()
    {
        isDead = true;
        GetComponent<MeshRenderer>().material.SetColor("_BaseColor", new Color(0.5f, 0.5f, 0.5f));
        GetComponent<BoxCollider>().enabled = false;

        if (GetComponent<MeshRenderer>().enabled == false)
            GetComponent<MeshRenderer>().enabled = true;

        if (GetComponent<Elf>() != null)
            GetComponent<Elf>().StopAllCoroutines();

        transform.position = new Vector3(transform.position.x, transform.localScale.y / 2, transform.position.z);
    }
}
