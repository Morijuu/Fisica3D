using UnityEngine;

public class Cohetes : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float Force = 10f;
    bool launching = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            launching = true;
        }
    }

    private void FixedUpdate()
    {
        if (launching == true)
        {
            rb.AddForce(Vector3.up * Force, ForceMode.Force);
        }

    }
}
