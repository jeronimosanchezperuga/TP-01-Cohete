using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlesCohete : MonoBehaviour
{
    public float speed;
    public float maxX = 8;
    public float minX = -8;
    public float minY = -4.1f;
    public float maxY = 3.1f;

   
    void Update()
    {
        float movX = Input.GetAxis("Horizontal");
        float movY = Input.GetAxis("Vertical");
        transform.Translate(movX * speed * Time.deltaTime, movY * speed * Time.deltaTime, 0);

        if (transform.position.x > maxX)
        {
            transform.position = new Vector3(maxX, transform.position.y, transform.position.z);
        }else if (transform.position.x < minX)
        {
            transform.position = new Vector3(minX, transform.position.y, transform.position.z);
        }
        if (transform.position.y > maxY)
        {
            transform.position = new Vector3(transform.position.x, maxY,transform.position.z);
        }
        else if (transform.position.y < minY)
        {
            transform.position = new Vector3(transform.position.x, minY, transform.position.z);
        }
    }
}
