using UnityEngine;
using UnityEngine.InputSystem;

public class Ej3 : MonoBehaviour
{
    private Rigidbody rb;
    private Vector2 move;

    [SerializeField] private float accelerationForce = 5f;
    [SerializeField] private float brakeForce = 2;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (move.y > 0) // W - acelerar
        {
            rb.AddForce(0f, 0f, move.y * accelerationForce);
        }
        else if (move.y < 0) // S - frenar
        {
            rb.AddForce(0f, 0f, move.y * brakeForce);
        }
    }

    void OnMove(InputValue value)
    {
        move = value.Get<Vector2>();
    }
}