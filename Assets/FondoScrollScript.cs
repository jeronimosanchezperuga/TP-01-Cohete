﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoScrollScript : MonoBehaviour
{
    public float displacementAmount;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ZonaDesplazamiento"))
        {
            transform.position += new Vector3(0,displacementAmount,0);
        }
    }
}
