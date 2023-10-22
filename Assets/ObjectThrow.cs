using UnityEngine;

public class ObjectThrow : MonoBehaviour
{
    public float throwForce = 10f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Vector3 throwDirection = Camera.main.transform.forward; 
            rb.AddForce(throwDirection * throwForce, ForceMode.Impulse);
        }
    }
}
