using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        print("Enter: " + collision.collider.name);
        if (collision.collider.name != "Floor" && collision.collider.name != "Wall1"
            && collision.collider.name != "Wall2" && collision.collider.name != "Wall3"
            && collision.collider.name != "Wall4")
            Destroy(collision.collider.gameObject);
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
