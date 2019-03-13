using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDemo : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        print("Trigger Enter: " + other.name);
        if(other.name == "Cube2")
        {
            Vector3 rotAng = new Vector3(0, 0, 0);
            rotAng.y += 0.1f;
            other.gameObject.transform.Rotate(rotAng);
        }
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
