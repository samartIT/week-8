﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceDemo : MonoBehaviour
{

    public Vector3 pushDirection = new Vector3(0, 0, 1);
    public float pushForce = 500;
    private void OnMouseOver()
    {
        GetComponent<Rigidbody>().AddForce(pushDirection * pushForce);
    }

    void Start()
    {  

    }

    void Update()
    {        
    }
}