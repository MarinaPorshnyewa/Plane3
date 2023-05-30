using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForTest : MonoBehaviour
{
    public GameObject BoxPrefab;

    public Material MaterialA;
    public Material MaterialB;

    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                GameObject newBox = Instantiate(BoxPrefab, new Vector3(i, 0, j), Quaternion.identity);

                if(((i % 2) == 0 && (j % 2) != 0) || ((i % 2) != 0 && (j % 2) == 0))
                {
                    newBox.GetComponent<Renderer>().material = MaterialA;
                }
                else
                {
                    newBox.GetComponent<Renderer>().material = MaterialB;
                }
                
                //if(Random.Range(0, 2) == 0)
                //{
                //    newBox.GetComponent<Renderer>().material = MaterialA;
                //}
                //else
                //{
                //    newBox.GetComponent<Renderer>().material = MaterialB;
                //}
                
            }
        }
    }
}
