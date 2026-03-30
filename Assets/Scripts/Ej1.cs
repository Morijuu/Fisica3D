using UnityEngine;
using UnityEngine.InputSystem;

public class Ej1 : MonoBehaviour
{
    private Rigidbody rb;
    private Vector2 move;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.AddForce(new Vector3(0f, 0f, move.y));
    }

    void OnMove(InputValue value)
    {
        move = value.Get<Vector2>();
    }
}