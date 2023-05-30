using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftControl : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float Speed = 5f;
    public float RotationSpeed = 1f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.maxAngularVelocity = Mathf.Infinity;
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal") * RotationSpeed;
        float v = Input.GetAxis("Vertical") * Speed;

        _rigidbody.AddRelativeForce(v, 0f, 0f);
        _rigidbody.AddRelativeTorque(0f, h, 0f);
    }
}
