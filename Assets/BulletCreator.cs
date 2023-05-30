using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreator : MonoBehaviour
{
    public GameObject BulletPrefab;
    public AudioSource ShotAudio;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CreateBullet();
        }
    }
    void CreateBullet()
    {
        GameObject newBullet = Instantiate(BulletPrefab, transform.position, transform.rotation);
        //velocity - задать скорость
        //newBullet.GetComponent<Rigidbody>().velocity = new Vector3(0f, 10f, 0f);
        newBullet.GetComponent<Rigidbody>().velocity = transform.forward * 10f;
        ShotAudio.pitch = Random.Range(0.8f, 1.2f);
        ShotAudio.Play();
    }
}
