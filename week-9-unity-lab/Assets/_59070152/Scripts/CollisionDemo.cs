﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDemo : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        print("Enter: " + collision.collider.name);
        if (collision.collider.name != "Cube3")
        {
            Destroy(collision.collider.gameObject);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        print("Enter: " + collision.collider.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        print("Enter: " + collision.collider.name);
    }
}
