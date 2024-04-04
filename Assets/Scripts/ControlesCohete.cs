using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlesCohete : MonoBehaviour
{
    public float speed;
    public float maxX = 8;
    public float minX = -8;
   
    void Update()
    {
        float movX = Input.GetAxis("Horizontal");
        transform.Translate(movX * speed * Time.deltaTime,0,0);

        if (transform.position.x > maxX)
        {
            transform.position = new Vector3(maxX, transform.position.y, transform.position.z);
        }else if (transform.position.x < minX)
        {
            transform.position = new Vector3(minX, transform.position.y, transform.position.z);
        }
    }
}
