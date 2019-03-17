using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    float rotAroundX, rotAroundY;
    void Update()
    {
        rotAroundY = Input.GetAxis("Mouse X");
        rotAroundX = Input.GetAxis("Mouse Y");
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
