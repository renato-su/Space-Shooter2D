using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Beam : MonoBehaviour

{
    AudioSource audioSource;
    GameController controller;

    public float speed = 10f; 

     void Start()
    {
        controller =GameObject.Find("GameController").GetComponent<GameController>();
        audioSource = gameObject.GetComponent<AudioSource>();
    }
    void Update()
    {

        transform.Translate(Vector3.up * speed * Time.deltaTime);

 
        if (transform.position.y > Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0)).y + 1)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
  
        if (collision.gameObject.tag=="Ball")
        {

            Destroy(gameObject); 

            controller.AddPoint(5);
        }
        if (collision.gameObject.tag == "Ball2")
        {{ 
            Destroy(gameObject);
                
            }
            controller.AddPoint(10);
        }
    }
}
