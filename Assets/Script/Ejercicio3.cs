using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{
    Rigidbody rb;
    float accel = 1000f;
    float frenado = 500f;
    float vel = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            vel += accel;
        }
        if (Input.GetKey(KeyCode.S))
        {
            vel -= frenado;
        }
        rb.AddForce(Vector3.forward * vel * Time.deltaTime, ForceMode.Force);
    }
}
