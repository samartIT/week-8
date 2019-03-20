using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class Relativemovement : MonoBehaviour
{
    [SerializeField] private Transform target;
    public float moveSpeed = 5.0f;
    public float rotationSpeed = 15.0f;
    private CharacterController _charCtrl;

    // Start is called before the first frame update
    void Start()
    {
        _charCtrl = GetComponent<CharacterController> ();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.zero;

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        if(horizontalInput != 0 || verticalInput != 0)
        {
            movement.x = horizontalInput * moveSpeed;
            movement.z = verticalInput * moveSpeed;

            movement = Vector3.ClampMagnitude(movement, moveSpeed);

            Quaternion tmp = target.rotation;
            target.eulerAngles = new Vector3(0, target.eulerAngles.y, 0);

            movement = target.TransformDirection(movement);

            target.rotation = tmp;
            //transform.rotation = Quaternion.LookRotation(movement);
            Quaternion direction = Quaternion.LookRotation(movement);
            transform.rotation = Quaternion.Lerp(transform.rotation, direction, rotationSpeed * Time.deltaTime);

        }
        movement *= Time.deltaTime;
        _charCtrl.Move(movement);
    }
}
