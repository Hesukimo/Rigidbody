using UnityEngine;

public class Ejercicio6 : MonoBehaviour
{
    Rigidbody rb;

    public GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 direction = Vector3.Normalize(player.transform.position - transform.position);
        rb.AddForce(direction, ForceMode.Acceleration);
    }
}
