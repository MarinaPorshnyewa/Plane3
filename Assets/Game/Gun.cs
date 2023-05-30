using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject BulletPrefab;
    public float BulletSpeed;
    public AudioSource ShotSount;

    public float ShotPeriod = 0.15f;
    private float _timer;

    void Update()
    {
        _timer += Time.deltaTime;

        if (Input.GetKey(KeyCode.Space))
        {
            if (_timer > ShotPeriod)
            {
                _timer = 0f;
                CreateBullet();
            }
            
        }
    }
    void CreateBullet()
    {
        GameObject newBullet = Instantiate(BulletPrefab, transform.position, transform.rotation);
        newBullet.GetComponent<Rigidbody>().velocity = transform.forward * BulletSpeed;
        ShotSount.pitch = Random.Range(0.8f, 1.2f);
        ShotSount.Play();
    }
}
