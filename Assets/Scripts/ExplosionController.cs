using UnityEngine;
using UnityEngine.InputSystem;

public class ExplosionController : MonoBehaviour
{

    PlayerInput playerInput;
    Rigidbody rb;
    Collider col;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody>();
        col = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInput.actions["Jump"].ReadValue<float>() > 0)
        {

            Collider[] colliders = Physics.OverlapSphere(transform.position, 5f);

            foreach (Collider col in colliders)
            {
                if (col.gameObject == gameObject) continue;

                Rigidbody rb = col.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.AddExplosionForce(50f, transform.position, 5f, 2f);
                }
            }
           
            print("Space");
        }
    }
}
