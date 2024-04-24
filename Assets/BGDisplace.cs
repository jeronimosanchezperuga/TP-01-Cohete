using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGDisplace : MonoBehaviour
{
    public float displaceAmount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("BGDisplaceZone"))
        {
            transform.position += new Vector3(0, displaceAmount, 0);
        }
    }
}
