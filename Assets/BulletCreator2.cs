using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreator2 : MonoBehaviour
{
    public GameObject BulletPrefab2;
    public float BulletVelocity = 20f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newBullet = Instantiate(BulletPrefab2, transform.position, transform.rotation);
            newBullet.GetComponent<Rigidbody>().velocity = transform.forward * BulletVelocity;
        }
    }
}
