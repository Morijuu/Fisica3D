using UnityEngine;
using UnityEngine.InputSystem;

public class Ej5 : MonoBehaviour
{
    private Rigidbody rb;
    private bool jump;
    [SerializeField] private float jumpForce;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
    }

    void OnJump(InputValue value)
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        print(value);
    }
}