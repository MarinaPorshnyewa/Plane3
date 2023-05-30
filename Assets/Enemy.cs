using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Player PlayerToAttack;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerToAttack.TakeDamage(2);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            PlayerToAttack.TakeDamage(5);
        }
    }
}
