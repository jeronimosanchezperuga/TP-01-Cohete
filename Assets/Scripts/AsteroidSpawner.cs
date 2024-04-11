using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public Vector3 newPosition;
    public float minX;
    public float maxX;
    public float spawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(CloneAsteroid), 0, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CloneAsteroid()
    {
        float randomx = Random.Range(minX, maxX);
        newPosition = new Vector3(randomx, newPosition.y);
        Instantiate(asteroidPrefab, newPosition, Quaternion.identity);
    }
}
