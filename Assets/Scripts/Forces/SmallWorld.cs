using UnityEngine;

public class SmallWorld : MonoBehaviour
{
    public float G = 9.8f; // constante gravitacional (puedes escalarla)

    Rigidbody rb;
    Rigidbody earthRb;
    public GameObject earth;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        earthRb = earth.GetComponent<Rigidbody>();
    }

    void FixedUpdate() // usar física aquí, no Update
    {
        Vector3 direction = earth.transform.position - transform.position;
        float distance = direction.magnitude;

        // Evitar división por cero
        if (distance == 0f) return;

        // Calcular fuerza gravitatoria
        float forceMagnitude = (G * rb.mass * earthRb.mass) / (distance * distance);

        Vector3 force = direction.normalized * forceMagnitude;

        rb.AddForce(force);
    }
}