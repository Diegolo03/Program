using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{
    [SerializeField] string moneda;
    [SerializeField] float cantidad;
    string cambio = "";
    // Start is called before the first frame update
    void Start()
    {
       float  conversion=Convertir(cantidad, moneda);
        Debug.Log("Son " + conversion + " en "+ cambio);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float Convertir(float cantidad, string moneda)
    {
        
        if (moneda=="euros")
        {
            float diferencia = 0.1122f;
            
            cantidad += cantidad * diferencia;
            cambio = "Dolares";

        }
        if(moneda=="dolares")
        {
            float diferencia = 0.1009f;
            cantidad -= cantidad * diferencia;
            cambio = "Euros";
        }
        return cantidad;

    }
}
