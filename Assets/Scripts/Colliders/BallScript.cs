using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class BallScript : MonoBehaviour
{

    private PlayerInput playerInput;
    private Rigidbody rb;

    private Vector2 move;
    private bool space;

    [SerializeField] private float ballForce = 5f;
    [SerializeField] private float ballRotation = 5f;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        move = playerInput.actions["Move"].ReadValue<Vector2>();
        space = playerInput.actions["Jump"].IsPressed();

        if (transform.position.y <= -1f || Input.GetKeyDown(KeyCode.R)) //reinicia la escena si se cae la bola o se pulsa la R
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }

    private void FixedUpdate()
    {
        if (rb.linearVelocity.z <= 0) //Permite rotar la bola solo cuando está quieta (en el inicio)
        {
            rb.MoveRotation(rb.rotation * Quaternion.Euler(0f, move.x * ballRotation * Time.deltaTime, 0f));
        }

        if (space && rb.linearVelocity.z <= 0) //Permite lanzar la bola solo cuando está quieta (en el inicio)
        {
            rb.AddForce(transform.forward * ballForce, ForceMode.Impulse); //aplica fuerza en la dirección que mira la bola
            rb.useGravity = true; //activa la gravedad solo cuando se hace el lanzamiento

            transform.GetChild(0).gameObject.SetActive(false); //elimina la guía de apuntado al lanzar
        }
    }
}
