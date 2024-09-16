using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_2 : MonoBehaviour
{
    [SerializeField] int numero1, numero2;
    // Start is called before the first frame update
    void Start()
    {
        if (numero1 > 3 && numero2 < 3)
        {
            Debug.Log("Numero 1 es mayor que 3, y el numero 2 es menor de 3");

        }
        else if (numero1 < 3 && numero2 > 3)
        {
            Debug.Log("Numero 1 es mayor que 3, y el numero 2 es menor de 3 ");

        }
        else if (numero1 < 3 && numero2 < 3)
        {
            Debug.Log("Ambos son menores de 3 ");

        }
        else if (numero1 > 3 && numero2 > 3)
        {
            Debug.Log("Ambos son mayores de 3 ");  

        }
        else if (numero1 == 3 && numero2 != 3)
        {
            Debug.Log("Numero 1 es igual a 3, y el numero 2 es distinto a 3");

        }
        else if (numero1 != 3 && numero2 == 3)
        {
            Debug.Log("Numero 1 es distinto a 3, y el numero 2 es igual a 3");

        }
        else
        {
            Debug.Log("Los dos números son iguales a 3");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
