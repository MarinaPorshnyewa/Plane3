using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public void OnHit()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * 160f);
        GetComponent<Rigidbody>().AddTorque(80f, 0f, 0f);
    }
}
