using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    float throwForce = 600;
    Vector3 objectPos;
    float distance;

    public bool canHold = true;
    public GameObject item;
    public GameObject tempParent;
    public bool isHolding = false;

    // Update is called once per frame
    void Update()
    {
        if (isHolding == true)
        {
            item.GetComponent<Rigidbody>().velocity = Vector3.zero;
            item.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            item.transform.SetParent(tempParent.transform); // Modificat de la item.transfer la item.transform
            if (Input.GetMouseButtonDown(1))
            {
                // Aruncare 
            }
        }
        else
        {
            objectPos = item.transform.position;
            item.transform.SetParent(null);
            item.GetComponent<Rigidbody>().useGravity = true; 
            item.transform.position = objectPos;
        }
    }

    void OnMouseDown()
    {
        isHolding = true;
        item.GetComponent<Rigidbody>().useGravity = false;
        item.GetComponent<Rigidbody>().detectCollisions = true;
    }

    void OnMouseUp()
    {
        isHolding = false;
    }
}
