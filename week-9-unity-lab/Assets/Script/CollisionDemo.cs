using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDemo : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        print("Enter: " + collision.collider.name);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
