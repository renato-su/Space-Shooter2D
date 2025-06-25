using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    const float moveMax = 5.0f;
    public float speed = 5f;
    public GameObject beamPrefab; 
    public Transform shootPoint; 

    private void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (this.transform.position.x <= moveMax)
            {
                transform.Translate(10.0f * Time.deltaTime, 0, 0);
            }
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.transform.position.x >= -moveMax)
            {
                transform.Translate(-10.0f * Time.deltaTime, 0, 0);
            }
        }

 
        if (Input.GetKeyDown(KeyCode.Space)==true)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
   
                Instantiate(beamPrefab, shootPoint.position, Quaternion.identity);

         
    }
}

