using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonScript : MonoBehaviour
{
    public GameObject botonNormalGO;
    public CoheteScript coheteScript;

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
        coheteScript.speed = 0.1f;
        coheteScript.fuegoGO.SetActive(true);
        Invoke(nameof(IrAEscenaJuego), 3);
    }

    private void OnMouseUp()
    {
        botonNormalGO.SetActive(true);
    }

    void IrAEscenaJuego()
    {
        SceneManager.LoadScene("Escena Juego");
    }
}
