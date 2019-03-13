using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTorqueDemo : MonoBehaviour
{
    public float torqueForce = 100;
    public Vector3 spinDirection = new Vector3(0, 1, 0);
    private void OnMouseOver()
    {
        GetComponent<Rigidbody>().AddTorque(spinDirection * torqueForce);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
