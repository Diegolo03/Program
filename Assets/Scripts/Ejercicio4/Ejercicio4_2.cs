using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{
    [SerializeField] string nombre, apellido1, apellido2,edad;
    // Start is called before the first frame update
    void Start()
    {

       string union= ConstruirNombre(nombre, apellido1, apellido2, edad);
        Debug.Log("La persona se llama " + union + " a�os");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    string ConstruirNombre(string nombre, string apellido1, string apellido2, string edad)
    {
        string texto = nombre + " " + apellido1 + " " + apellido2 + " y tiene " + edad;

        return texto;
    }

}
