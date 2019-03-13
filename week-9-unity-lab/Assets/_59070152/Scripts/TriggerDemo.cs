using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDemo : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print("Trigger Enter: " + other.name);
    }

    private void OnTriggerStay(Collider other)
    {
        print("Trigger Stay: " + other.name);
        if(other.name == "Cube2")
        {
            Vector3 rotAng = new Vector3(0, 0, 0);
            rotAng.y += 0.1f;
            other.gameObject.transform.Rotate(rotAng);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        print("Trigger Exit: " + other.name);
    }
}
