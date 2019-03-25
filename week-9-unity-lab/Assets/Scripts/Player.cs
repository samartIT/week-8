using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        float rotAroundX = Input.GetAxis("Horizontal");
        float rotAroundY = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(rotAroundX, 0.0f, rotAroundY);
        rb.AddForce(movement * speed);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Barrier"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
