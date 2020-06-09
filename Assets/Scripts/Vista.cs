using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vista : Modelo
{
    public Text textorespuesta;
    public GameObject cuadro;
    public GameObject Botton;
    // Start is called before the first frame update
    void Start()
    {
        cuadro.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Showtext() 
        {
        textorespuesta.text = texto1;
        cuadro.SetActive(true);
        Botton.SetActive(false);
            
    }
    public void Closetext () {
        cuadro.SetActive(false);
        Botton.SetActive(true);
    }
}
