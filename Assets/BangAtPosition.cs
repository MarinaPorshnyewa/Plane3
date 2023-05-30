using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BangAtPosition : MonoBehaviour
{
    public Rigidbody TargetRigidbody;
    public float ForceValue = 100f;

    //public ParticleSystem ParticleSystem;
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            TargetRigidbody.AddForceAtPosition(transform.up * ForceValue, transform.position);
            //ParticleSystem.Play();
        }
    }
}
