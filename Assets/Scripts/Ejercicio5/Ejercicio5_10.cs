using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_10 : MonoBehaviour
{
    [SerializeField] int tp;
    // Start is called before the first frame update
    void Start()
    {
        if (tp <= 10)
        {
            Debug.Log("El clima es: Frío");
        }
        else if (tp > 10 && tp <= 20)
        {
            Debug.Log("El clima es: Nublado");
        }
        else if (tp > 20 && tp <= 30)
        {
            Debug.Log("El clima es: Caluroso");
        }
        else if (tp > 30)
        {
            Debug.Log("El clima es: Tropical");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
