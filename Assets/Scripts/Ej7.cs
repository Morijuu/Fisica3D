using UnityEngine;
using UnityEngine.InputSystem;

public class Ej7 : MonoBehaviour
{
    private Rigidbody rb;
    private Vector2 move;

    [SerializeField] private float speed = 5f;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.AddTorque(new Vector3(0f, move.x, 0f) * speed);
    }

    void OnMove(InputValue value)
    {
        move = value.Get<Vector2>();
    }
}