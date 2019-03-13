using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDemo : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        print("Enter: " + collision.collider.name);
        if (collision.collider.name != "Cube3")
            Destroy(collision.collider.gameObject);
    }
    /* private void OnCollisionStay(Collision collision)
    {
        print("Stay: " + collision.collider.name);
    }
    private void OnCollisionExit(Collision collision)
    {
        print("Exit: " + collision.collider.name);
    } */
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
