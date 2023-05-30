using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class Bullet : MonoBehaviour
{
    private bool isActive = true;
    public GameObject MarkPrefab;

    private void OnCollisionEnter(Collision collision)
    {
        if (!isActive)
        {
            return;
        }
        isActive = false;

        GetComponent<Rigidbody>().useGravity = true;

        Debug.Log(collision.gameObject.name);

        Enemy2 enemy = collision.gameObject.GetComponent<Enemy2>();
        if (enemy)
        {
            enemy.OnHit();
        }

        Vector3 position = collision.contacts[0].point;
        Quaternion rotation = Quaternion.LookRotation(collision.contacts[0].normal);

        Instantiate(MarkPrefab, position, rotation);
    }
}
*/