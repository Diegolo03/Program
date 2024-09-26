using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_13 : MonoBehaviour
{
    [SerializeField] int numero;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(EsPrimo(numero));
        // Mi metodo no funciono como pensé, así que pense un poco y recorde como hacer la cuenta de dividir entre los anteriores apra ver si alguno daba 0
    }
    bool EsPrimo(int numero)
    {
        if (numero <= 1)
        {
            return false;
        }
            

        for (int i = 2; i <= numero / 2; i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
                
        }
        return true;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
