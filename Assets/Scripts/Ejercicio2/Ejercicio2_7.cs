using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_7 : MonoBehaviour
{
    int farmeo = 7, tiempoCompleto = 60, horas = 4, oroTotal;
    // Start is called before the first frame update
    void Start()
    {
        oroTotal = ((farmeo * tiempoCompleto)*tiempoCompleto)*horas;
        Debug.Log("Oro Total: " + oroTotal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
