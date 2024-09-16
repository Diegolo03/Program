using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_2 : MonoBehaviour
{
    int vidas=10;
    float exp=3.3f, resultadoSuma, resultadoResta;
    char carc;
    // Start is called before the first frame update
    void Start()
    {
        resultadoSuma = vidas + exp;
        resultadoResta = exp - vidas;
        Debug.Log("Resultado Suma: "+ resultadoSuma + ", Resultado Resta: "+ resultadoResta);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
