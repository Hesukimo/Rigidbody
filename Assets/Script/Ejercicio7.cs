using UnityEngine;

public class Ejercicio7 : MonoBehaviour
{
    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddTorque(Vector3.left * 10f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddTorque(Vector3.right * 10f);
        }
    }
}
