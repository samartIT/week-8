using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class RelativeMovement : MonoBehaviour
{
    [SerializeField] private Transform target;
    public float moveSpeed = 5.0f;
    private CharacterController _charCtrl;
    public float rotationSpeed = 15.0f;
    public float jumpSpeed = 15.0f;
    public float gravity = -9.8f;
    public float terminalVelocity = -10.0f;
    public float minFall = -1.5f;
    private float _vertSpeed;

    void Start()
    {
        _charCtrl = GetComponent<CharacterController>();
        _vertSpeed = minFall;
    }

    void Update()
    {
        Vector3 movement = Vector3.zero;

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        if (horizontalInput != 0 || verticalInput != 0)
        {
            movement.x = horizontalInput * moveSpeed;
            movement.z = verticalInput * moveSpeed;

            movement = Vector3.ClampMagnitude(movement, moveSpeed);

            Quaternion tmp = target.rotation;
            target.eulerAngles = new Vector3(0, target.eulerAngles.y, 0);

            movement = target.TransformDirection(movement);

            target.rotation = tmp;
            Quaternion direction = Quaternion.LookRotation(movement);
            transform.rotation = Quaternion.Lerp(transform.rotation, direction, rotationSpeed * Time.deltaTime);
        }
        print(_charCtrl.isGrounded);
        if (_charCtrl.isGrounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                _vertSpeed = jumpSpeed;
            }
            else
            {
                _vertSpeed = minFall;
            }
        }
        else
        {
            _vertSpeed += gravity * 5 * Time.deltaTime;
            if (_vertSpeed < terminalVelocity)
            {
                _vertSpeed = terminalVelocity;
            }
        }
            movement.y = _vertSpeed;
        
        movement *= Time.deltaTime;
        _charCtrl.Move(movement);
    }
}
