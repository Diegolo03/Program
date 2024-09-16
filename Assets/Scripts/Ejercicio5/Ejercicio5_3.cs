using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_3 : MonoBehaviour
{
    [SerializeField] int numero1;
    // Start is called before the first frame update
    void Start()
    {
        if (numero1 >0 && numero1 <9)
        {
            Debug.Log("Esta comprendido entre 0 y 9");

        }
        else if (numero1 > 9)
        {
            Debug.Log("Numero 1 es mayor que 9");

        }

        else if (numero1 <0)
        {
            Debug.Log("Numero 1 es menor que 0");

        }
        else if (numero1 == 9)
        {
            Debug.Log("Esta comprendido entre 0 y 9, y el numero 1 es igual a 9");

        }
        else if (numero1 == 0)
        {
            Debug.Log("Esta comprendido entre 0 y 9, y el numero 1 es igual a 0");

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
