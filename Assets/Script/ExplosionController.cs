using UnityEngine;

public class ExplosionController: MonoBehaviour
{
    float radio = 5f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, radio);
            foreach (Collider collider in colliders)
            {
                collider.attachedRigidbody.GetComponent<Rigidbody>().AddExplosionForce(500f, transform.position, radio, 2f);
            }
        }
    }
}
