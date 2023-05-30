using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour
{
    public GameObject BoxPrefab;

    public Material MaterialA;
    public Material MaterialB;
    
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    GameObject newBoxPrefab = Instantiate(BoxPrefab, transform.position, transform.rotation, transform);
        //    newBoxPrefab.transform.localScale = Vector3.one * Random.Range(0.5f, 1f);

        //    if(Random.Range(0, 2) == 0)
        //    {
        //        newBoxPrefab.GetComponent<Renderer>().material = MaterialA;               
        //    }
        //    else
        //    {
        //        newBoxPrefab.GetComponent<Renderer>().material = MaterialB;
        //    }
        //}
    }
}
