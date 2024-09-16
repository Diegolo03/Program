using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{
    [SerializeField] string nombre, apellido1, apellido2;
    [SerializeField] int edad;
    // Start is called before the first frame update
    void Start()
    {

        ConstruirNombre(nombre, apellido1, apellido2, edad);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ConstruirNombre(string nombre, string apellido1, string apellido2, int edad)
    {
        Debug.Log("La persona se llama " + nombre + " " + apellido1 + " " + apellido2 + " y tiene "+edad+" años");

    }

}
