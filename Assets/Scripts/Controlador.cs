using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controlador : MonoBehaviour
{
    public string actualText;
    bool _bol;
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Modelo>().bol = true;        
    }

    // Update is called once per frame
    void Update()
    {
        _bol = GetComponent<Modelo>().bol;
        if (_bol == true)
        {
            actualText = GetComponent<Modelo>().texto1;
        }
        else if (_bol == false)
        {
            actualText = GetComponent<Modelo>().texto2;
        }
    }

    public void ChangeText()
    {
        if (GetComponent<Modelo>().bol == true)
        {
            Debug.Log(actualText);
            GetComponent<Modelo>().bol = false;
        }
        else if (GetComponent<Modelo>().bol == false)
        {
            Debug.Log(actualText);
            GetComponent<Modelo>().bol = true;
        }


    }
}
