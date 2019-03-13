using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastDemo : MonoBehaviour
{
    float rotAroundX, rotAroundY;

    // Update is called once per frame
    void Update()
    {
        rotAroundX = Input.GetAxis("Mouse Y");
        rotAroundY = Input.GetAxis("Mouse X");
        transform.Rotate(rotAroundX, -rotAroundY, 0);
        DestroyObject();
    }

    void DestroyObject()
    {
        if(Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
        {
            print(hit.collider.name + " has been destroyed.");
            Destroy(hit.collider.gameObject);
        }
    }
}
