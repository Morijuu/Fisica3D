using UnityEngine;
using UnityEngine.InputSystem;

public class Ej2 : MonoBehaviour
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
        rb.AddForce(new Vector3(move.x, 0f, move.y) * speed);
    }

    void OnMove(InputValue value)
    {
        move = value.Get<Vector2>();
    }
}