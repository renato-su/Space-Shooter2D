using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGenerator : MonoBehaviour
{
    public GameObject ballPrefab; 
    public float interval = 1.5f; 
    public GameObject ballPrefab2D;
    public float interval2 = 3.0f;
    float timer = 0;
    float time2 = 0;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= interval) 
        {
            timer = 0; 

            GameObject o = Instantiate(ballPrefab);

            o.transform.position = new Vector3(Random.Range(-5, 5), 7, 0); 
        }
        time2 += Time.deltaTime;
        if (time2 >= interval2) 
        {
            time2 = 0; 

      
            GameObject ob = Instantiate(ballPrefab2D);

            ob.transform.position = new Vector3(Random.Range(-5, 5), 7, 0); 
        }
    }
}


