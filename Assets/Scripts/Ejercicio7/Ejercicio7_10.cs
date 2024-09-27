using Palmmedia.ReportGenerator.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Ejercicio7_10 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int numero0, numero1;
    void Start()
    {
        

        Debug.Log("Números entre " + numero0 + " y " + numero1 + " son:");
        if (numero0 > numero1)
        {
            for (int i = numero0; i <= numero1; i--)
            {
                if (i % 2 == 0)
                {
                    Debug.Log(i + " par");
                }
                else
                {
                    Debug.Log(i + " impar");
                }
                if (i > 0)
                {
                    Debug.Log(i + " positivo");
                }
                else
                {
                    Debug.Log(i + " negativo");
                }
            }
        }
        else
        {
            for (int i = numero1; i >= numero0; i--)
            {
                if (i % 2 == 0)
                {
                    Debug.Log(i + " par");
                }
                else
                {
                    Debug.Log(i + " impar");
                }
                if (i > 0)
                {
                    Debug.Log(i + " positivo");
                }
                else
                {
                    Debug.Log(i + " negativo");
                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {



    }

}
