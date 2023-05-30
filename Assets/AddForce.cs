using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.AddForce(new Vector3(0f, 300f, 0f));
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _rigidbody.AddForce(new Vector3(-15f, 0f, 0f));
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rigidbody.AddForce(new Vector3(15f, 0f, 0f));
        }
        
    }
}
