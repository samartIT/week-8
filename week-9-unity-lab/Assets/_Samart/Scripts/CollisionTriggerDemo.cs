using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTriggerDemo : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        print("Enter: " + collision.collider.name);
        if (collision.collider.name != "Cube3")
            Destroy(collision.collider.gameObject);
    }

    private void OnCollisionStay(Collision collision)
    {
        print("Stay on : " + collision.collider.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        print("Exis from: " + collision.collider.name);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        print("Trigger Enter: " + other.name);
    }

    private void OnTriggerStay(Collider other)
    {
        print("Trigger Stay on: " + other.name);
        if (other.name == "Cube2")
        {
            Vector3 rotAng = new Vector3(0, 0, 0);
            rotAng.y += 0.1f;
            other.gameObject.transform.Rotate(rotAng);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        print("Trigger Exit from: " + other.name);
    }

}
