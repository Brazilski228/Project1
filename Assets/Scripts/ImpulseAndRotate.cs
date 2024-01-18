using UnityEngine;

public class ImpulseAndRotate : MonoBehaviour
{
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();       
    }

    private void OnEnable()
    {
        rb.velocity = Vector3.zero;
        rb.AddForce(Vector3.up * Random.Range(12, 17), ForceMode.Impulse); 
        rb.AddTorque(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10), ForceMode.Impulse);
    }
}
