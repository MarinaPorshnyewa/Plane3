using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator2 : MonoBehaviour
{
    public GameObject CoinPrefab;
    public GameObject BombPrefab;

    private float time = 10f;

    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            if(Random.Range(0, 3) == 0)
            {
                Vector3 position = new Vector3(i, Random.Range(-15f, 15f), 0);

                if (Random.Range(0, 3) == 0)
                {
                    Instantiate(BombPrefab, position, Quaternion.identity);
                }
                else
                {
                    Instantiate(CoinPrefab, position, Quaternion.identity);
                }             
            }
            
        }
    }

    private void Update()
    {
        time -= Time.deltaTime;
        if(time <= 0)
        {
            // to do

            time = 10f;
        }
    }

}
