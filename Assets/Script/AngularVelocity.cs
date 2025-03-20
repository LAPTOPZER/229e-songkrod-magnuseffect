using UnityEngine;

public class AngularVelocity : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 angularV;
    [SerializeField] Vector3 torque;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.angularVelocity = angularV;
        }
        else if (Input.GetMouseButtonDown(1))
        {
            rb.AddTorque(torque);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.angularVelocity = Vector3.zero;
        }
    }
}
