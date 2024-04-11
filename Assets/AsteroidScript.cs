using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    public float rotationSpeed;
    public float fallingSpeed;
    public float maxScale;
    public float minScale;

    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = Random.Range(-rotationSpeed, rotationSpeed);
        transform.localScale *= Random.Range(minScale,maxScale);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * fallingSpeed * Time.deltaTime, Space.World);
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
