using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axis : MonoBehaviour
{

    public float Speed;
    
    void Update()
    {
        //Debug.Log(transform.position.x);
        // Debug.Log(transform.forward); //направление по оси Z
        //Debug.Log(transform.right); //направление по оси X
        //Debug.Log(transform.up); //направление по оси Y

        //if (transform.forward.y > 0)
        //{
        //    GetComponent<Renderer>().material.color = Color.red;
        //}
        //else
        //{
        //    GetComponent<Renderer>().material.color = Color.yellow;
        //}

        transform.position += transform.forward * Time.deltaTime * Input.GetAxis("Vertical") * Speed;
        transform.position += transform.right * Time.deltaTime * Input.GetAxis("Horizontal") * Speed;


    }
}
