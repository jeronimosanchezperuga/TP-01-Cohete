using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonScript : MonoBehaviour
{
    public GameObject botonNormalGO;

    // Start is called before the first frame update
    void Start()
    {
        botonNormalGO.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Detecta si el usuario hizo click sobre el collider
    //del objeto que tiene este script
    private void OnMouseDown()
    {
        //Debug.Log("Click");
        botonNormalGO.SetActive(false);
    }

    private void OnMouseUp()
    {
        botonNormalGO.SetActive(true);
    }
}
