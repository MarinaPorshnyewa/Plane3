using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody))]
public class BiplaneMove : MonoBehaviour
{
    private Rigidbody _rigidbody;

   [SerializeField] private float ConstantForceValue = 0.2f;
    public float ForceValue = 15f;
    public float TorqueValue;

    public Action CollectCoin;
    public Action CollectBomb;

    public Biplane Biplane;
    public Score Score;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        CollectCoin += Score.AddOne;
        CollectBomb += Biplane.OnCollectBomb;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _rigidbody.AddForce(transform.forward * ConstantForceValue, ForceMode.VelocityChange);
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            _rigidbody.AddForce(transform.forward * ForceValue, ForceMode.VelocityChange);
        }

        float horizontalInput = Input.GetAxis("Horizontal");
        _rigidbody.AddTorque(transform.right * TorqueValue * horizontalInput, ForceMode.VelocityChange);
    }

    private void OnTriggerEnter(Collider other)
    {
        Bomb bomb = other.gameObject.GetComponent<Bomb>();

        if (bomb)
        {
            CollectBomb.Invoke();
            bomb.Die();
        }

        Coin coin = other.gameObject.GetComponent<Coin>();
        if (coin)
        {
            CollectCoin.Invoke();
        }
    }
}
