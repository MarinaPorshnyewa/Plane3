using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float RotationSercetivity;
    public Transform CameraTransform;
    public Rigidbody Rigidbody;
    public float Speed;
    public float JumpForce;

    private bool _grounded;

    private float _xRotation;

    void Update()
    {

        if (Input.GetMouseButton(1))
        {
            _xRotation -= Input.GetAxis("Mouse Y")*RotationSercetivity;
            _xRotation = Mathf.Clamp(_xRotation, -60f, 60f);
            CameraTransform.localEulerAngles = new Vector3(_xRotation, 0f, 0f);

            transform.Rotate(0, Input.GetAxis("Mouse X")*RotationSercetivity, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_grounded)
            {
                Rigidbody.AddForce(0, JumpForce, 0, ForceMode.Impulse);
            }           
        }
    }
    private void FixedUpdate()
    {
        Vector3 inputVector = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        Vector3 speedVector = inputVector * Speed;

        Vector3 speedVectorRelativeToPlayer = transform.TransformVector(speedVector);
        Rigidbody.velocity = new Vector3(speedVectorRelativeToPlayer.x, Rigidbody.velocity.y, speedVectorRelativeToPlayer.z);
    }

    private void OnCollisionStay(Collision collision)
    {
        Vector3 normal = collision.contacts[0].normal;
        float dot = Vector3.Dot(normal, Vector3.up);

        if (dot > 0.5)
        {
            _grounded = true;
        }
        
    }
    private void OnCollisionExit(Collision collision)
    {
        _grounded = false;
    }
}
