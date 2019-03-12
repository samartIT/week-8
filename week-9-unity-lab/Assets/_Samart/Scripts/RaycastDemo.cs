using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastDemo : MonoBehaviour
{

    float rotAroundX, rotAroundY;
    
    void Update()
    {
        rotAroundY = Input.GetAxis("Mouse X");
        rotAroundX = Input.GetAxis("Mouse Y");
        transform.Rotate(rotAroundX, -rotAroundY, 0);
        DestroyObject();    // Call Destroy function
    }

    void DestroyObject()
    {
        // Check if Raycast found any hit object in the direction of
        // Camera pointing forward. Found and Destroy.
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
        {
            print(hit.collider.name + " has been destroyed.");
            Destroy(hit.collider.gameObject);
        }
    }
}
