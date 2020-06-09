using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vista : Controlador
{
    public Text textorespuesta;
    public GameObject cuadro;
    public GameObject Botton;
    // Start is called before the first frame update
    void Start()
    {
        //cuadro.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        textorespuesta.text =GameObject.Find("BotonParaMostrar").GetComponent<Controlador>().actualText;
    }
    //public void Showtext() 
        //{
        //textorespuesta.text = actualText;
        //cuadro.SetActive(true);
        //Botton.SetActive(false);
            
    //}
   // public void Closetext () {
        //cuadro.SetActive(false);
        //Botton.SetActive(true);
    //}
}
