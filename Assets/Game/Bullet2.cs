using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Bomb bomb = other.gameObject.GetComponent<Bomb>();

        if (bomb)
        {          
            bomb.Die();
            Destroy(gameObject);
        }       
    }
}
