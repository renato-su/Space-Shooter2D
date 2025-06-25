using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Ball2 : MonoBehaviour
{
    GameController control;
    public GameObject particlePrefab;
    public GameObject particlePrefab2;
    private int n = 0;

    void Start()
    {
        control = GameController.Instance;
        if (control == null)
        {
            Debug.LogError("GameController não encontrado!");
        }
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
            n++;
            if (n == 2)
            {
                if (particlePrefab != null)
                {
                    Instantiate(particlePrefab, transform.position, Quaternion.identity); 
                }
                Destroy(gameObject);
            }
        }
       else if (col.gameObject.tag == "Earth")
        {
            
            if (particlePrefab != null)
            {
                Instantiate(particlePrefab, transform.position, Quaternion.identity); 
            }
            Destroy(gameObject);
            control.AddPoint(-20);
        }
      
    }
}
