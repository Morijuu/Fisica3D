using UnityEngine;
using UnityEngine.InputSystem;

public class Ej4 : MonoBehaviour
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
        rb.linearVelocity = new Vector3(move.x, rb.linearVelocity.y, move.y) * speed;
    }

    void OnMove(InputValue value)
    {
        move = value.Get<Vector2>();
    }
}