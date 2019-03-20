using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrditCamera : MonoBehaviour
{
    [SerializeField] private Transform target;
    public float rotateSpeed = 1.5f;
    private float _rotateY;
    private Vector3 _offset;

    void Start()
    {
        _rotateY = transform.eulerAngles.y;
        _offset = target.position - transform.position;
    }

    void LateUpdate()
    {
        float horInput = Input.GetAxis("Horizontal");

        if (horInput!= 0)
        {
            _rotateY += horInput * rotateSpeed;
        }
        else
        {
            _rotateY += Input.GetAxis("Mouse X") * rotateSpeed * 3;
        }

        Quaternion rotation = Quaternion.Euler(0, _rotateY, 0);
        transform.position = target.position - (rotation * _offset);
        transform.LookAt(target);
    }

}
