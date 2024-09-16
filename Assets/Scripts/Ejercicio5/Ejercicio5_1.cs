using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_1 : MonoBehaviour
{
    [SerializeField] int vida1, vida2;
    // Start is called before the first frame update
    void Start()
    {
        if (vida1 == vida2)
        {
            Debug.Log("Ambas vidas son iguales");

        }
        else if (vida1 <= vida2)
        {
            Debug.Log("La segunda vida es mayor por: " + (vida2-vida1));

        }
        else if (vida1 >= vida2)
        {
            Debug.Log("La primera vida es mayor por: " + (vida1 - vida2));

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
