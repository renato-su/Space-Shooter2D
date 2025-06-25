using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Ball : MonoBehaviour
{
    GameController control;
    public GameObject particlePrefab;
    public GameObject particlePrefab2;
    void Start()
    {
        control = GameObject.Find("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5.0f)　
        {
            Destroy(gameObject); 
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Beam")
        {
            if (particlePrefab2 != null)
            {
                Instantiate(particlePrefab2, transform.position, Quaternion.identity); 
            }
            Destroy(gameObject);


        }
        else if (col.gameObject.tag == "Earth")
        {
            if (particlePrefab != null)
            {
                Instantiate(particlePrefab, transform.position, Quaternion.identity); 
            }
            Destroy(gameObject);
            control.AddPoint(-10);
        }
      
       
    }
  
    
}
