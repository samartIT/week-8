using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDemo.cs : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
{
    print("Enter: " + collision.collider.name);

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
