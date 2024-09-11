using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{
    int vidas = 10,dobleVidas;
    float exp = 3.3f, tripleExp, producto,cociente,resto;
    // Start is called before the first frame update
    void Start()
    {
        producto = vidas * exp;
        cociente=vidas / exp;
        resto=vidas % exp;
        dobleVidas=vidas * 2;
        tripleExp=exp * 3f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
