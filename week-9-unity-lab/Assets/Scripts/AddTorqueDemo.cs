using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTorqueDemo : MonoBehaviour
{
    // Start is called before the first frame update
    public float torqueForce = 100;
    public Vector3 spinDirection = new Vector3(0, 1, 0);
    private void OnMouseOver()
    {
        GetComponent<Rigidbody>().AddTorque(spinDirection * torqueForce);
    }
}
