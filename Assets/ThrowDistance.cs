using UnityEngine;

public class ThrowDistance : MonoBehaviour
{
    public float distanceThrown; 

    private void Start()
    {
        distanceThrown = 0f;
    }

    public void UpdateDistance(Vector3 throwPosition)
    {
        distanceThrown = Vector3.Distance(throwPosition, transform.position);
    }
}
