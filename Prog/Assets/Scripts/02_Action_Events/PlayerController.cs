using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float rotationSpeed;

    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotationSpeed * 100f * Time.deltaTime, 0);
        transform.position += transform.forward * Input.GetAxis("Vertical") * speed * 50f * Time.deltaTime;
    }
}
