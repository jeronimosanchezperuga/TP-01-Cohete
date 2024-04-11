using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuegoScript : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = Vector3.one * Random.Range(.7f,1.2f); ;
    }
}
