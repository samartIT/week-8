using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDemo : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print("Trigger Enter: " + other.name);
    }
    private void OnCollisionStay(Collider other)
    {
        print("Trigger Stay on: " + other.name);
        if (other.name == "Cube2")
        {
            Vector3 rotAng = new Vector3(0, 0, 0);
            rotAng.y += 0.1f;
            other.gameObject.transform.Rotate(rotAng);
        }
    }
    private void OnCollisionExit(Collider other)
    {
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
