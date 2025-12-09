using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime, Space.World);
    }
}
